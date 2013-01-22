using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Pagos
    {
        private Alumnos alumnos;

        public Alumnos Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }
        private DateTime fechaPago;

        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }
        private int valorAbono;

        public int ValorAbono
        {
            get { return valorAbono; }
            set { valorAbono = value; }
        }
        private string concepto;

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }
        private string mesPorPagar;

        public string MesPorPagar
        {
            get { return mesPorPagar; }
            set { mesPorPagar = value; }
        }
        private int horasPagadas;

        public int HorasPagadas
        {
            get { return horasPagadas; }
            set { horasPagadas = value; }
        }
    }
}
