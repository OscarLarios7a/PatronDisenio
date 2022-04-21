using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PatronDiseño_MVC.MODELS.DAO
{
    public class DbConexion 
    {
        protected SqlConnection conexion = new SqlConnection("Server=DESKTOP-UATUHL3;DataBase=Practica_Patrones;integrated Security=true;");
    }
}
