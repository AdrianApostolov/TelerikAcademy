var express = require('express');
var path = require('path');
var rootPath = path.normalize(__dirname + '/');
var PORT = 4000;
var app = express();

app.use(express.static(rootPath + 'public'));
require('./server/config/routes')(app);

app.set('view engine', 'jade');
app.set('views', __dirname + '/server/views');

app.listen(PORT);
console.log("Server running on port: " + PORT);