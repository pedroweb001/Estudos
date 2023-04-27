const uuid = require("uuid/v4");

module.exports = () => {
    const customerWalletsDB = require("../data/customer-wallets.json");
    const customerWalletsDTO = require("../models/customerWallets");
    const controller = {}

    const { customerWallets: customerWalletsMock } = customerWalletsDB;

    controller.listCustomerWallets = async (req, res) => {
        const CW = await customerWalletsDTO.findAll()
            .then(() => {
                return res.status(200).json(CW);
            })
            .catch(() => {
                return res.status(400).json({
                    message: "Deu ruim.",
                })
            });
    }

    controller.saveCustomerWallets = async (req, res) => {
            await customerWalletsDTO.create(req.body)
            .then(()=>{
                return res.status(200).json({
                    message:"CustomerWallets criado com sucesso",
                });
            })
            .catch(()=>{
                return res.status(400).json({
                    message:"Não foi possível criar o customerWallets",
                });
            });
        res.status(201).json(customerWalletsMock);
    }

    controller.removeCustomerWallets = (req, res) => {
        const { id } = req.params;

        const foundCustomerIndex = customerWalletsMock.data.findIndex(customer => customer.id == id);

        if (foundCustomerIndex == -1) {
            res.status(404).json({
                message: "Cliente não encontrado.",
                success: false,
                customerWallets: customerWalletsMock,
            });
        }
        else {
            customerWalletsMock.data.splice(foundCustomerIndex, 1);
            res.status(200).json({
                message: "Cliente removido com sucesso!",
                sucess: true,
                customerWallets: customerWalletsMock,
            });
        }
    }

    controller.updateCustomerWallets = (req, res) => {
        const { id } = req.params;

        const foundCustomerIndex = customerWalletsMock.data.findIndex(customer => customer.id == id);

        if (foundCustomerIndex == -1) {
            res.status(404).json({
                message: "Cliente não encontrado.",
                success: false,
                customerWallets: customerWalletsMock,
            });
        }
        else {
            const newCustomer = {
                id: id,
                parentId: req.body.parentId,
                name: req.body.name,
                birthDate: req.body.birthDate,
                cellphone: req.body.cellphone,
                phone: req.body.phone,
                email: req.body.email,
                occupation: req.body.occupation,
                state: req.body.state,
                createdAt: new Date(),
            }
            customerWalletsMock.data.splice(foundCustomerIndex, 1, newCustomer);
            res.status(200).json({
                message: "Cliente atualizado com sucesso!",
                sucess: true,
                customerWallets: customerWalletsMock,
            });
        }
    }



    return controller;
}