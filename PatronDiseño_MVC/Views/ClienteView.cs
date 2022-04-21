using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatronDiseño_MVC.CONTROLLERS;

namespace PatronDiseño_MVC.Views
{
    public partial class ClienteView : Form
    {
        private ClienteView()
        {
            InitializeComponent();
            ClienteController ctrl = new ClienteController(this);

        }
        private static ClienteView instancia = null;
        public static ClienteView obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ClienteView();
            }
            return instancia;
        }
    }
}
