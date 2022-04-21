using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatronDiseño.IU;

namespace PatronDiseño
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientesDTO frmCliente = FormClientesDTO.obtenerInstancia();
            frmCliente.MdiParent = this;
            frmCliente.Show();
            frmCliente.BringToFront();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibros frmLibros = FormLibros.obtenerInstancia();
            frmLibros.MdiParent = this;
            frmLibros.Show();
            frmLibros.BringToFront();
        }
    }
}
