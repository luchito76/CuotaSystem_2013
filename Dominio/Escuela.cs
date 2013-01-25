using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Escuela
    {
        private int idEscuela;

        public int IdEscuela
        {
            get { return idEscuela; }
            set { idEscuela = value; }
        }

        private string nombreEscuela;

        public string NombreEscuela
        {
            get { return nombreEscuela; }
            set { nombreEscuela = value; }
        }
    }
}
