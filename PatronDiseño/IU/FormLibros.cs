using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronDiseño.IU
{
    public partial class FormLibros : Form
    {
        //Patron SINGLENTON
        private FormLibros()
        {
            InitializeComponent();
        }
        private static FormLibros instancia = null;
        #region Metodo para el Manejo del formulario con el patron SINGLENTON
        public static FormLibros obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FormLibros();
            }
            return instancia;
        }
        #endregion

        private void FormLibros_Load(object sender, EventArgs e)
        {

        }
    }
}
