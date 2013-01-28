using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class GradosEscuela
    {
        private int idGrados;

        public int IdGrados
        {
            get { return idGrados; }
            set { idGrados = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
