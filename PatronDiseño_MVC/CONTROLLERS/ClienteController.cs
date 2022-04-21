using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronDiseño_MVC.MODELS.DAO;
using PatronDiseño_MVC.MODELS.DTO;
using PatronDiseño_MVC.Views;



namespace PatronDiseño_MVC.CONTROLLERS
{
    class ClienteController
    {
        ClienteView view;
        //Contructor
        public ClienteController (ClienteView View)
        {
            view = View;
            view.Load += new EventHandler(clienteLista);
        }
        private void clienteLista(object sender, EventArgs e) {
            Cliente_Models_DAO db = new Cliente_Models_DAO();
            view.dtgvClienteView.DataSource = db.verRegistrosClientesDTO(view.txtBuscarClientesView.Text);
        }
    }
}
