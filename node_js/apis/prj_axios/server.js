const Express = require("express")
const app = Express()
const axios = require("axios")

app.get("/", (req, res)=>{
axios.get("https://api.github.com/users/pedroweb001")
.then((resultado)=>{
res.send("<img src='" + resultado.data.avatar_url + "'></img>")
})
.catch((error)=>{
    console.log(error)
})
})

app.listen(3000, ()=>{
    console.log("Aplicação rodando na porta 3000")
})