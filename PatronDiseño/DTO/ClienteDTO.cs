using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño.DTO
{
    class ClienteDTO
    {
        //Atributos debe ser privados para seguridad 
        private int id;
        private string nombre;
        private string apellido;
        private string direcion;
        private string ciudad;
        private string email;
        private string telefono;
        private string ocupacion;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Direcion
        {
            get
            {
                return direcion;
            }

            set
            {
                direcion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Ocupacion
        {
            get
            {
                return ocupacion;
            }

            set
            {
                ocupacion = value;
            }
        }



        // Propiedades Getters y Setters


    }
}
