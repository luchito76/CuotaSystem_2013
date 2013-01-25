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
        private Decimal dni;

        public Decimal Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private Decimal telefonoFijo;

        public Decimal TelefonoFijo
        {
            get { return telefonoFijo; }
            set { telefonoFijo = value; }
        }
        private Decimal telefonoCelular;

        public Decimal TelefonoCelular
        {
            get { return telefonoCelular; }
            set { telefonoCelular = value; }
        }

        private string relacion;

        public string Relacion
        {
            get { return relacion; }
            set { relacion = value; }
        }

        private Alumnos alumno;

        public Alumnos Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }
    }
}
