using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Examen
    {
        private Decimal valorExamen;

        public Decimal ValorExamen
        {
            get { return valorExamen; }
            set { valorExamen = value; }
        }

        public override string ToString()
        {
            return String.Format("{0}", ValorExamen.ToString("C2"));
        }
    }
}
