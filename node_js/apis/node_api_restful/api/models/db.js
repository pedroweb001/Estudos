const { Sequelize } = require("sequelize");

const sequelize = new Sequelize("cw", "root", "root", {
    host:"localhost",
    dialect:"mysql",
});

sequelize.authenticate()
    .then(() => {
        console.log("Conectado com sucesso!");
    })
    .catch(() => {
        console.log("Erro ao conectar com o banco de dados!");
    });

    module.exports = sequelize;