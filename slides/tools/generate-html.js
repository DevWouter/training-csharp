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

    var links = mdFiles
        .map(mdFile => path.basename(mdFile))
        .map(mdFile => {
            return "<a href='" + mdFile.replace('.md', '.html') + "'>" + getTitleOfMarkdown(mdFile) + "</a>";
        }).map(link => "<li>" + link + "</li>");
    
    var linkMap = "<ul class='chapter-list'>\n"+ links.join('\n') + "\n</ul>";



    // For each markdown file, generate the HTML file
    mdFiles.forEach(mdFile => {
        console.log(`Generating ${mdFile.replace('.md', '.html')}`);
        const htmlFile = mdFile.replace('.md', '.html');
        let pageData = ddata;

        // Read the first line of the markdown file
        let title = getTitleOfMarkdown(mdFile);

        pageData = pageData.replace(/\$MARKDOWN_TITLE\$/g, path.basename(title));
        pageData = pageData.replace(/\$MARKDOWN_FILE\$/g, path.basename(mdFile));
        pageData = pageData.replace(/\$MARKDOWN_CHAPTERS\$/g, linkMap);

        fs.writeFileSync(htmlFile, pageData);
    });
    // });
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

