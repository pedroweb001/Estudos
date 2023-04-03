module.exports = app=>{
    const controller = require("../controlers/customerWallets")();
   app.route("/api/v1/customerWallets")
   .get(controller.listCustomerWallets)
   .post(controller.saveCustomerWallets);
}