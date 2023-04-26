// A simple http web-server, which will render a index page with a list of files in the current directory.
// The server will also serve the files in the current directory.

using System;
using System.IO;
using System.Net;

var server = new HttpListener();
var prefix = "http://localhost:8080/";
server.Prefixes.Add(prefix);
server.Start();

Console.WriteLine($"Listening on {prefix}...");

while (true)
{
    var context = server.GetContext();
    var request = context.Request;
    var response = context.Response;

    Console.WriteLine($"{request.HttpMethod} {request.Url}");
    if (request.Url.AbsolutePath == "/")
    {
        var stringBuilder = new System.Text.StringBuilder();
        
        stringBuilder.AppendLine("<!DOCTYPE html>");
        stringBuilder.AppendLine("<html>");
        stringBuilder.AppendLine("<head>");
        stringBuilder.AppendLine($"<title>Index of {request.Url.AbsolutePath}</title>");
        stringBuilder.AppendLine("</head>");
        stringBuilder.AppendLine("<body>");
        stringBuilder.AppendLine($"<h1>Index of {request.Url.AbsolutePath}</h1>");
        stringBuilder.AppendLine("<ul>");

        var files = Directory.GetFiles(Directory.GetCurrentDirectory());
        foreach (var file in files)
        {
            stringBuilder.AppendLine($"<li><a href=\"{Path.GetFileName(file)}\">{Path.GetFileName(file)}</a></li>");
        }
        
        stringBuilder.AppendLine("</ul>");
        stringBuilder.AppendLine("</body>");
        stringBuilder.AppendLine("</html>");
        
        var html = stringBuilder.ToString();
        var buffer = System.Text.Encoding.UTF8.GetBytes(html);
        
        response.ContentLength64 = buffer.Length;
        response.OutputStream.Write(buffer, 0, buffer.Length);
        response.OutputStream.Close();
    }
    else
    {
        var path = request.Url.AbsolutePath.Substring(1);
        if (File.Exists(path))
        {
            var buffer = File.ReadAllBytes(path);
            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }
        else
        {
            response.StatusCode = 404;
            response.OutputStream.Close();
        }
    }
}