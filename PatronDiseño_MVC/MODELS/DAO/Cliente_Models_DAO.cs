using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PatronDiseño_MVC.MODELS.DTO;

namespace PatronDiseño_MVC.MODELS.DAO
{
    class Cliente_Models_DAO:DbConexion
    {
        //Atributos
        SqlDataReader leerFilas;
        SqlCommand comando = new SqlCommand();
        //metodos CRUD;
        #region Metodo Create- Insertar

        #endregion

        #region Metodo Reader- Leer
        public List<Cliente_Models_DTO> verRegistrosClientesDTO(string cadena)
        {
            comando.Connection = conexion;
            comando.CommandText = "verRegistros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@condicion", cadena);
            conexion.Open();

            leerFilas = comando.ExecuteReader();
            List<Cliente_Models_DTO> listaGenerica = new List<Cliente_Models_DTO>();

            while (leerFilas.Read())
            {
                listaGenerica.Add(new Cliente_Models_DTO
                {
                    Id = leerFilas.GetInt32(0),
                    Nombre = leerFilas.GetString(1),
                    Apellido = leerFilas.GetString(2),
                    Direcion = leerFilas.GetString(3),
                    Ciudad = leerFilas.GetString(4),
                    Email = leerFilas.GetString(5),
                    Telefono = leerFilas.GetString(6),
                    Ocupacion = leerFilas.GetString(7),

                });
            }
            leerFilas.Close();
            conexion.Close();
            return listaGenerica;

        }
        #endregion

        #region Metodo Update- Editar

        #endregion


        #region Metodo Delete- Eliminar

        #endregion

    }
}
