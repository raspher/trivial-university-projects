const http = require('http');

const hostname = '127.0.0.1';
const port = 80;

const server = http.createServer((req, res) => {
    res.statusCode = 200;
    res.setHeader('Content-Type', 'text/html; charset=UTF-8')
    res.write(`
        <html>
            <head>
                <title>OK</title>
            </head>
            <body>
                <h1>OK: 200</h1>
            </body>
        </html>
    `);
    res.end();
})

server.listen(port,hostname, () => {
    console.log(`Serwer uruchomiony - adres: ${hostname}, port: ${port}`);
}
);