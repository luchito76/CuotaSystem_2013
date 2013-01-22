using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class FliaAutorizada
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private int telefonoFijo;

        public int TelefonoFijo
        {
            get { return telefonoFijo; }
            set { telefonoFijo = value; }
        }
        private int telefonoCelular;

        public int TelefonoCelular
        {
            get { return telefonoCelular; }
            set { telefonoCelular = value; }
        }
    }
}
