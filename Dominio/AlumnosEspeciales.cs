using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class AlumnosEspeciales
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
        private int valorHora;

        public int ValorHora
        {
            get { return valorHora; }
            set { valorHora = value; }
        }
        private bool rindeExamen;

        public bool RindeExamen
        {
            get { return rindeExamen; }
            set { rindeExamen = value; }
        }
        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private Examen examen;

        public Examen Examen
        {
            get { return examen; }
            set { examen = value; }
        }
    }
}
