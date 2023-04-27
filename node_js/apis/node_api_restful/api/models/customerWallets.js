const { Sequelize } = require("sequelize");
const db = require("./db");


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
    birthdate: {
        type: Sequelize.STRING,
        allowNull: false,
    },
    cellphone: {
        type: Sequelize.INTEGER,
        allowNull: false,
    },
    phone: {
        type: Sequelize.INTEGER,
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
    state: {
        type: Sequelize.STRING,
        allowNull: false,
    },
    createdAt: {
        type: Sequelize.STRING,
        allowNull: false,
    }
});



module.exports = customerWallets;