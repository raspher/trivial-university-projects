const path = require('path');
const http = require('http');
const fs = require('fs');
const { exception } = require('console');
const { isUndefined } = require('util');

// change as needed
const hostname = '127.0.0.1';
const port = 8080; // port 80 is usually blocked by firewall

// supported filetypes
var mime = {
    html: 'text/html',
    css: 'text/css',
    jpg: 'image/jpeg',
    png: 'image/png',
    bmp: 'image/bmp',
    js: 'application/javascript'
};

var server = http.createServer(function (req, res) {
    if (req.method == 'GET'){
        // fix index page
        if (req.url === '/') req.url = '/index.html';

        // try parse file extension to fulfill Context-Type
        try
        {
            ext = mime[path.parse(req.url).ext.slice(1)];
            if (ext === undefined) throw "Error: filetype not supported";
        }
        catch(err)
        {
            console.log(`${err}`);
            res.writeHead(404);
            res.end();
            return;
        }

        // finally check if there is file, if it is - return data from file
        fs.readFile(`.${req.url}`, (err, data) => {
            if (err){
                res.writeHead(404);
                console.log(`${err}`);
                res.end();
                return;
            }
            res.writeHead(200, {
                'Content-Type': `${ext}`,
                'Cache-Control': 'public, max-age=60'})
            res.end(data);
        })
    }
});

server.listen(port,hostname, () => {
    console.log(`Serwer uruchomiony - adres: ${hostname}, port: ${port}`);
}
);