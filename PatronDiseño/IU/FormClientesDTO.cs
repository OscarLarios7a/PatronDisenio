using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatronDiseño.DAO;

namespace PatronDiseño.IU
{
    public partial class FormClientesDTO : Form
    {

        //Patron SINGLENTON
        private FormClientesDTO() // modificamos el constructor a privado
        {
            InitializeComponent();
        }
        private static FormClientesDTO instancia = null;

        #region Metodo para el Manejo del formulario con el patron SINGLENTON
        public static FormClientesDTO obtenerInstancia()
        {
            if (instancia==null)
            {
                instancia = new FormClientesDTO();
            }
            return instancia;
        }
        #endregion

        #region verRegistros
        private void verRegistros(string cadena)
        {
            ClienteDAO clientesDAO = new ClienteDAO();
            dtgvClientes.DataSource = clientesDAO.verRegistrosClientesDTO(cadena);


        }
        #endregion

        private void FormClientesDTO_Load_1(object sender, EventArgs e)
        {
            verRegistros("");
        }

        private void bntBuscarClientes_Click(object sender, EventArgs e)
        {
            verRegistros(txtBuscarClientes.Text);
        }

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            verRegistros(txtBuscarClientes.Text);
        }
    }
}
