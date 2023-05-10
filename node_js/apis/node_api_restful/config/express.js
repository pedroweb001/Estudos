const express = require("express");
const bodyParser = require("body-parser");
const config = require("config");

module.exports = ()=>{
 const app = express();   
 app.use(express.urlencoded({
    extended: true}))

 app.set('port', process.env.PORT || config.get('server.port'));
 app.use(bodyParser.json());

 require ("../api/routs/customerWallets")(app);
 return app;
}