using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PatronDiseño.DAO
{
    class ConexionSQL
    {
        protected SqlConnection conexion = new SqlConnection("Server=DESKTOP-UATUHL3;DataBase=Practica_Patrones;integrated Security=true;");
    }
}
