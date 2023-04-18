const uuid = require("uuid/v4");

module.exports = () => {
    const customerWalletsDB = require("../data/customer-wallets.json");
    const controller = {}

    const { customerWallets: customerWalletsMock } = customerWalletsDB;

    controller.listCustomerWallets = (req, res) => {
        res.status(200).json(customerWalletsDB);
    }

    controller.saveCustomerWallets = (req, res) => {
        customerWalletsMock.data.push({
            id: uuid(),
            name: req.body.name,
            birthDate: req.body.birthDate,
            parentId: uuid(),
            email: req.body.email,
            occupation: req.body.occupation,
            cellphone: req.body.cellphone,
            phone: req.body.phone,
            state: req.body.state
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
    return controller;
}