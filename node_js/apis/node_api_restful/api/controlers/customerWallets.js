const uuid = require("uuid/v4");

module.exports = () => {
    const customerWalletsDB = require("../data/customer-wallets.json");
    const customerWalletsDTO = require("../models/customerWallets");
    const controller = {}

    controller.listCustomerWallets = async (req, res) => {
        const CW = await customerWalletsDTO.findAll({
            attributes: [
                "name"
            ]
        })
            .then(() => {
                console.log("CW: " + CW);
                return res.status(200).json(CW);
            })
            .catch(() => {
                return res.status(400).json({
                    message: "Deu ruim.",
                })
            });
    }

    controller.saveCustomerWallets = async (req, res) => {
        const { name, email, occupation } = req.body;
        await customerWalletsDTO.create({ name, email, occupation })
            .then(() => {
                return res.status(200).json({
                    message: "CustomerWallets criado com sucesso",
                });
            })
            .catch(() => {
                return res.status(400).json({
                    message: "Não foi possível criar o customerWallets",
                });
            });
    }

    controller.removeCustomerWallets = async (req, res) => {
        const { id } = req.params;

        try {
            const cw = await customerWalletsDTO.destroy({
                where:{
                    id:id
                }
            });
            return res.status(200).json(cw);
        }
        catch
        {
            return res.status(400).json({ message: "Deu ruim" });
        }
    }

    controller.updateCustomerWallets = async (req, res) => {
        const { name, email, occupation } = req.body;
        const { id } = req.params;

        try {
            const CW = await customerWalletsDTO.update(
                { name: name, email: email, occupation: occupation },
                { where:
                     { id: id }
                     });
            return res.status(200).json(CW);
        }
         catch {
            return res.status(400).json({
                 message: "Deu ruim"
                 });
        }
    }

    return controller;
}