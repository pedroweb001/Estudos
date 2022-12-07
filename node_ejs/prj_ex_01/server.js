var express = require('express');
var app = express();
app.set('view engine', 'ejs');
app.get('/', function(req, res){
res.render('./index');
})
app.get('/sobre', function(req, res){
    res.render('./sobre');
    });
app.listen(8080);
console.log("Rodando");