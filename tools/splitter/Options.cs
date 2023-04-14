using CommandLine;

namespace splitter;

internal class ProgramOptions
{
    [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
    public bool Verbose { get; set; }
        
    [Option('s', "solution", Required = true, HelpText = "Solution to be split")]
    public string SolutionPath { get; set; }
        
    [Option('o', "outputDirectory", Required = true, HelpText = "Output directory")]
    public string OutputDirectory { get; set; }
    
    [Option('f', "force", HelpText = "Force splitting the solution")]
    public bool Force { get; set; }
}