using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Cursos:Matricula 
    {
        
        private int idCurso;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private decimal montoCuota;

        public decimal MontoCuota
        {
            get { return montoCuota; }
            set { montoCuota = value; }
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
        private Matricula matricula;

        public Matricula Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
    }
}
