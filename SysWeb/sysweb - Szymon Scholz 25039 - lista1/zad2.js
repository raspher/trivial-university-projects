const http = require('http');
const { url } = require('inspector');

const hostname = '127.0.0.1';
const port = 80;

const server = http.createServer((req, res) => {
    if (req.url == '/a')
        res.writeHead(301, {Location: 'https://google.pl/'});
    if (req.url == '/b')
        res.writeHead(301, {Location: 'https://youtube.pl/'});
    res.end();
})

server.listen(port,hostname, () => {
    console.log(`Serwer uruchomiony - adres: ${hostname}, port: ${port}`);
}
);