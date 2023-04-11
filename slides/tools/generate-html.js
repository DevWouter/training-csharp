const fs = require('fs');
const path = require('path');

const templateFilePath = path.join(process.cwd(), '_template.html');

console.log('Template file: ' + templateFilePath);

// List all the markdown files in the current directory
if (!fs.existsSync(templateFilePath)) {
    console.error('Template file not found');
    process.exit(1);
}


const files = fs.readdirSync(process.cwd());
const mdFiles = files.filter(f => f.endsWith('.md') && !f.startsWith('README.md'));
const htmlFiles = files.filter(f => f.endsWith('.html') && !f.startsWith('_template'));

// Check which files will be overwritten
const filesToOverwrite = htmlFiles.filter(f => mdFiles.includes(f.replace('.html', '.md')));
if (filesToOverwrite.length > 0) {
    // Ask for confirmation
    console.log('The following files will be overwritten:');
    filesToOverwrite.forEach(element => {
        console.log(`- ${element}`);
    });
}

const forceFlag = process.argv.includes('--force');

if (forceFlag || filesToOverwrite.length === 0) {
    generateHTML();
} else {
    const rl = require('readline').createInterface({
        input: process.stdin,
        output: process.stdout
    });

    // Check if the --force flag is set
    if (!process.argv.includes('--force')) {
        rl.question('Do you want to continue? (y/n) ', (answer) => {
            rl.close();
            if (answer.toLowerCase() === 'y') {
                generateHTML();
            }
        });
    }
}

function generateHTML() {
    console.log('Generating HTML files...');


    // Load the template file in memory
    var ddata = fs.readFileSync(templateFilePath, 'utf8', (err, data) => {
        console.log({ err, data });
        if (err) {
            console.error(err);
            return;
        }
    });

    // For each markdown file, generate the HTML file
    mdFiles.forEach((currentMdFile, currentMdFileIndex) => {
        console.log(`Generating ${currentMdFile.replace('.md', '.html')}`);

        var links = mdFiles
            .map(mdFile => {
                return { path: path.basename(mdFile), current: path.basename(mdFile) === path.basename(currentMdFile) };
            })
            .map(({ path, current }, index) => {
                const title = getTitleOfMarkdown(path);
                const href = path.replace('.md', '.html');
                const linkClasses = ['chapter-menu-item-title'];
                const itemClasses = ['chapter-menu-item'];

                const lines = [`<li class="${itemClasses.join(' ')}">`];
                lines.push(`<a class="${linkClasses.join(' ')}" href="${href}">`);

                if (index == currentMdFileIndex) {
                    lines.push(`<i class="fas fa-arrow-alt-circle-right fa-fw"></i>`);
                }
                if (index < currentMdFileIndex) {
                    lines.push(`<i class="fas fa-check-circle fa-fw"></i>`);
                }
                if (index > currentMdFileIndex) {
                    lines.push(`<i class="far fa-circle fa-fw"></i>`);
                }
                lines.push(`${title}`);
                lines.push(`</a>`);
                lines.push(`</li>`);

                return lines.join('\n');
            });

        var linkMap = "<ul class='chapter-menu-items'>\n" + links.join('\n') + "\n</ul>";


        const htmlFile = currentMdFile.replace('.md', '.html');
        let pageData = ddata;

        // Read the first line of the markdown file
        let title = getTitleOfMarkdown(currentMdFile);

        pageData = pageData.replace(/\$MARKDOWN_TITLE\$/g, path.basename(title));
        pageData = pageData.replace(/\$MARKDOWN_FILE\$/g, path.basename(currentMdFile));
        pageData = pageData.replace(/\$MARKDOWN_CHAPTERS\$/g, linkMap);

        fs.writeFileSync(htmlFile, pageData);
    });
}

function getTitleOfMarkdown(mdFile) {
    const firstLine = fs.readFileSync(mdFile, 'utf8', (err, data) => {
        console.log({ err, data });
        if (err) {
            console.error(err);
            return;
        }
    }).split('\r')[0];

    let title = path.basename(mdFile);
    if (firstLine.startsWith('# ')) {
        title = firstLine.replace(/^\# +/, '');
    }
    return title;
}

