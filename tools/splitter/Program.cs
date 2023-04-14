using System.Diagnostics;
using System.Text.RegularExpressions;
using CommandLine;
using Microsoft.Build.Construction;
using SlnParser;
using SlnParser.Contracts;

namespace splitter;

internal static class Program
{
    public static void Main(string[] args)
    {
        var result = Parser.Default.ParseArguments<ProgramOptions>(args);
        result.WithNotParsed((errs) =>
        {
            var errors = errs as Error[] ?? errs.ToArray();
            Console.WriteLine("errors {0}:", errors.Count());
            foreach (var error in errors)
            {
                Console.WriteLine($"- {error}");
            }
        }).WithParsed(options =>
        {
            // Check if solution exists
            string solutionPath = Path.GetFullPath(options.SolutionPath);
            if (!File.Exists(solutionPath))
            {
                throw new FileNotFoundException("Unable to find solution", solutionPath);
            }

            // Check if directory exists 
            string outputDirectory = Path.GetFullPath(options.OutputDirectory);

            // Check if directory is empty
            if (Directory.Exists(outputDirectory) && Directory.EnumerateFileSystemEntries(outputDirectory).Any())
            {
                if (options.Force)
                {
                    Console.WriteLine("Output directory is not empty, but --force was specified. Deleting all files in the output directory.");
                    foreach (var file in Directory.EnumerateFiles(outputDirectory, "*", SearchOption.AllDirectories))
                    {
                        File.Delete(file);
                    }

                    // Delete folders
                    foreach (var dir in Directory.EnumerateDirectories(outputDirectory, "*", SearchOption.AllDirectories))
                    {
                        Directory.Delete(dir, true);
                    }
                }
                else
                {
                    throw new Exception("Output directory is not empty. Use --force to delete all files in the output directory.");
                }
            }

            // Directory is now empty, so we can start splitting the solution
            // New structure
            // - Demos
            //   - Chapter 1 (those are all the projects that start with "C01_D")
            // - Problems
            //   - Chapter 1
            //     - Problem 1 (those are all the projects that start with "C01_L01P")
            // - Solutions
            //   - Chapter 1 (will have a solution)
            //     - Problem 1 (those are all the projects that start with "C01_L01S")

            // Regex for demo projects
            var demoRegex = new Regex(@"^C(?<chapter>\d+)_D(?<demo>\d+)");
            var problemRegex = new Regex(@"^C(?<chapter>\d+)_L(?<lab>\d+)P_");
            var solutionRegex = new Regex(@"^C(?<chapter>\d+)_L(?<lab>\d+)S_.*?(_P(?<part>\d+))?$");

            // Parse solution
            var solutionParser = new SolutionParser();
            var parsedSolution = solutionParser.Parse(solutionPath);

            // Create chapter folders
            var parsedProjects = new List<TrainingProject>();
            var unparsedProjects = new List<string>();
            foreach (var project in parsedSolution.AllProjects.Select(x => x as SolutionProject).Where(x => x != null).Cast<SolutionProject>())
            {
                var isDemo = demoRegex.IsMatch(project.Name);
                var isProblem = problemRegex.IsMatch(project.Name);
                var isSolution = solutionRegex.IsMatch(project.Name);

                // Must be either demo, problem or solution, but not more than one
                var isMultiple = new[] { isDemo, isProblem, isSolution }.Count(x => x) > 1;
                var isNeither = new[] { isDemo, isProblem, isSolution }.Count(x => x) == 0;
                if (isNeither)
                {
                    unparsedProjects.Add(project.Name);
                    continue;
                }

                if (isMultiple)
                {
                    throw new Exception($"Project {project.Name} is both a demo, problem and solution")
                    {
                        Data =
                        {
                            { "project", project },
                            { "isDemo", isDemo },
                            { "isProblem", isProblem },
                            { "isSolution", isSolution }
                        }
                    };
                }


                if (options.Verbose)
                {
                    Console.WriteLine($"Project {project.Name} is a {(isDemo ? "demo" : isProblem ? "problem" : "solution")}");
                }

                if (isDemo)
                {
                    var parsedProjectName = demoRegex.Match(project.Name);
                    parsedProjects.Add(new TrainingProject(
                        project,
                        TrainingProjectType.Demo,
                        int.Parse(parsedProjectName.Groups["chapter"].Value),
                        int.Parse(parsedProjectName.Groups["demo"].Value),
                        null
                    ));
                }

                if (isProblem)
                {
                    var parsedProjectName = problemRegex.Match(project.Name);
                    parsedProjects.Add(new TrainingProject(
                        project,
                        TrainingProjectType.Problem,
                        int.Parse(parsedProjectName.Groups["chapter"].Value),
                        int.Parse(parsedProjectName.Groups["lab"].Value),
                        null
                    ));
                }

                if (isSolution)
                {
                    var parsedProjectName = solutionRegex.Match(project.Name);
                    parsedProjects.Add(new TrainingProject(
                        project,
                        TrainingProjectType.Solution,
                        int.Parse(parsedProjectName.Groups["chapter"].Value),
                        int.Parse(parsedProjectName.Groups["lab"].Value),
                        parsedProjectName.Groups["part"].Success ? int.Parse(parsedProjectName.Groups["part"].Value) : null
                    ));
                }
            }


            // List all unparsed projects
            if (unparsedProjects.Any())
            {
                Console.WriteLine("The following projects could not be parsed and are skipped:");
                foreach (var unparsedProject in unparsedProjects)
                {
                    Console.WriteLine($"- {unparsedProject}");
                }
            }

            // Create folders
            var demosDirectory = Path.Combine(outputDirectory, "Demos");
            var problemsDirectory = Path.Combine(outputDirectory, "Problems");
            var solutionsDirectory = Path.Combine(outputDirectory, "Solutions");

            Directory.CreateDirectory(demosDirectory);
            Directory.CreateDirectory(problemsDirectory);
            Directory.CreateDirectory(solutionsDirectory);

            foreach (var project in parsedProjects)
            {
                Console.WriteLine(project.Project.File.FullName);
                var sourceDirectory = project.Project.File.Directory;
                var targetDirectory = project.Type switch
                {
                    TrainingProjectType.Demo => Path.Combine(demosDirectory, $"Chapter_{project.Chapter:d2}", sourceDirectory.Name),
                    TrainingProjectType.Problem => Path.Combine(problemsDirectory, $"Chapter_{project.Chapter:d2}", sourceDirectory.Name),
                    TrainingProjectType.Solution => Path.Combine(solutionsDirectory, $"Chapter_{project.Chapter:d2}", $"P{project.Index}",
                        sourceDirectory.Name),
                    _ => throw new ArgumentOutOfRangeException()
                };

                var skipDirectories = new Regex[]
                {
                    new Regex("[\\\\/]bin([\\\\/]|$)"),
                    new Regex("[\\\\/]obj([\\\\/]|$)"),
                };

                // Regenerate the directory structure
                Directory.CreateDirectory(targetDirectory);
                foreach (var dir in sourceDirectory.EnumerateDirectories("*", SearchOption.AllDirectories))
                {
                    if (skipDirectories.Any(x => x.IsMatch(dir.FullName)))
                    {
                        continue;
                    }

                    var relativePath = Path.GetRelativePath(sourceDirectory.FullName, dir.FullName);
                    var targetDir = Path.Combine(targetDirectory, relativePath);

                    Directory.CreateDirectory(targetDir);
                }

                // Copy all files
                foreach (var file in sourceDirectory.EnumerateFiles("*", SearchOption.AllDirectories))
                {
                    if (skipDirectories.Any(x => x.IsMatch(file.FullName)))
                    {
                        continue;
                    }

                    var targetFile = PathToTargetDirectory(sourceDirectory.FullName, targetDirectory, file.FullName);
                    if (File.Exists(targetFile))
                    {
                        File.Delete(targetFile);
                    }

                    Console.WriteLine("Copying " + file.FullName + " to " + targetFile + "");
                    File.Copy(file.FullName, targetFile);
                }

                // Check if sln file exists
                var slnFolder = Path.Combine(targetDirectory, Path.GetDirectoryName(targetDirectory));
                var slnFile = Path.Combine(slnFolder, Path.GetFileName(slnFolder) + ".sln");
                
                if(project.Type == TrainingProjectType.Solution)
                {
                    // Use the parent folder as sln folder
                    slnFolder = Path.GetDirectoryName(slnFolder);
                    slnFile = Path.Combine(slnFolder, Path.GetFileName(slnFolder) + ".sln");
                }
                
                if (!File.Exists(slnFile))
                {
                    // Create sln file
                    RunProcess(targetDirectory, "dotnet", $"new sln -n \"{Path.GetFileNameWithoutExtension(slnFile)}\" -o \"{slnFolder}\"");
                }
                
                // Add project to sln file
                var targetProj = PathToTargetDirectory(sourceDirectory.FullName, targetDirectory, project.Project.File.FullName);
                RunProcess(targetDirectory, "dotnet", $"sln \"{slnFolder}\" add \"{targetProj}\"");
            }
        });
    }

    private static string PathToTargetDirectory(string sourceDir, string targetDirectory, string filepath)
    {
        var relativePath = Path.GetRelativePath(sourceDir, filepath);
        var targetFile = Path.Combine(targetDirectory, relativePath);
        return Path.GetFullPath(targetFile);
    }

    private static void RunProcess(string targetDirectory, string command, string arguments)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = command,
            Arguments = arguments,
            UseShellExecute = false,
            RedirectStandardOutput = false,
            CreateNoWindow = false,
            WorkingDirectory = targetDirectory
        };
        
        Console.WriteLine($"Running {command} {arguments} in {targetDirectory}");
        var process = new Process
        {
            StartInfo = startInfo
        };
        process.Start();
        process.WaitForExit();
        if (process.ExitCode != 0)
        {
            throw new Exception($"Command {command} {arguments} failed with exit code {process.ExitCode}");
        }
    }
}

public enum TrainingProjectType
    {
        Problem,
        Solution,
        Demo
    }

    public record TrainingProject(
        SolutionProject Project,
        TrainingProjectType Type,
        int Chapter,
        int Index,
        int? Part);