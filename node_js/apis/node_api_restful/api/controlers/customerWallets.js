const uuid = require("uuid/v4");

module.exports = ()=>{
    const customerWalletsDB = require("../data/customer-wallets.json");
    const controller = {}

    const {customerWallets:customerWalletsMock} = customerWalletsDB;

    controller.listCustomerWallets = (req, res)=>{
        res.status(200).json(customerWalletsDB);
    } 

    controller.saveCustomerWallets = (req, res)=>{
        customerWalletsMock.data.push({
            id:uuid(),
            name:req.body.name,
            birthDate:req.body.birthDate,
            parentId:uuid(),
            email:req.body.email,
            occupation:req.body.occupation,
            cellphone:req.body.cellphone,
            phone:req.body.phone,
            state:req.body.state
        });
        res.status(201).json(customerWalletsMock);
    }
    return controller;
}