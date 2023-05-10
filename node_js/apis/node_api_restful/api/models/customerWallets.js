const { Sequelize } = require("sequelize");
const db = require("./db");
const sequelize = require("./db");


const customerWallets = db.define("customerWallets", {
    id: {
        type: Sequelize.INTEGER,
        autoIncrement: true,
        allowNull: false,
        primaryKey: true,
    },
    name: {
        type: Sequelize.STRING,
        allowNull: false,
    },
    email: {
        type: Sequelize.STRING,
        allowNull: false,
    },
    occupation: {
        type: Sequelize.STRING,
        allowNull: false,
    },
});


sequelize.sync();
module.exports = customerWallets;