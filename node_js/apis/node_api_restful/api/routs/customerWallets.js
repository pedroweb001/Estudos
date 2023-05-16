module.exports = app=>{
    const controller = require("../controlers/customerWallets")();
   app.route("/api/v1/customerWallets")
   .get(controller.listCustomerWallets)
   .post(controller.saveCustomerWallets);
   
   app.route("/api/v1/customerWallets/:id")
   .delete(controller.removeCustomerWallets)
   .put(controller.updateCustomerWallets)
}