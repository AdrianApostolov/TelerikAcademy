var formidable = require('formidable'),
    http = require('http'),
    fs = require('fs'),
    port = 1111,
    storedFile;


http.createServer(function (req, res) {
    if (req.url === '/upload' && req.method.toLowerCase() == 'post') {
        // parse a file upload
        var form = new formidable.IncomingForm();
        form.uploadDir = "Images";
        form.encoding = 'utf-8';
        form.keepExtensions = true;
        res.writeHead(200, {'Content-Type': 'text/html'});

        form.parse(req, function (err, fields, files) {});

        form.on('progress', function (bytesReceived, bytesExpected) {
            var progress = (bytesReceived / bytesExpected) * 100;
            res.write(parseInt(progress) + ' % <br />');
            if (progress === 100) {
                res.write('<h2>Successfully upload.</h2>');
                res.write('<a href="/download">Download</a>');
                storedFile = form.openedFiles[0].path;
                res.end();
            }
        });
    }
    else if (req.url === '/download') {
        fs.readFile(storedFile, function (err, data) {
            res.writeHead(200, {'Content-Type': 'image/jpeg'});
            res.end(data); // Send the file data to the browser.

        });
    }
    else {
        // show a file upload form
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end(
            '<div>' +
                '<form action="/upload" method="post" enctype="multipart/form-data">' +
                '   <input type="file" size=80 name="pic" ><input type="submit" value="Upload">' +
                '</form>' +
            '</div>'
        );
    }
}).listen(port);

console.log('Server is running on port ' + port);