using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Alumnos
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
        
        private int nroMatricula;

        public int NroMatricula
        {
            get { return nroMatricula; }
            set { nroMatricula = value; }
        }
        
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        
        private DateTime fechaInscripcion;

        public DateTime FechaInscripcion
        {
            get { return fechaInscripcion; }
            set { fechaInscripcion = value; }
        }
        
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        private Cursos curso;

        public Cursos Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        
        private string nomPadre;

        public string NomPadre
        {
            get { return nomPadre; }
            set { nomPadre = value; }
        }
        
        private string nomMadre;

        public string NomMadre
        {
            get { return nomMadre; }
            set { nomMadre = value; }
        }
        
        private Escuela escuela;

        public Escuela Escuela
        {
            get { return escuela; }
            set { escuela = value; }
        }
        
        private string turno;

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        
        private string grado;

        public string Grado
        {
            get { return grado; }
            set { grado = value; }
        }
        
        private bool planillaSanitaria;

        public bool PlanillaSanitaria
        {
            get { return planillaSanitaria; }
            set { planillaSanitaria = value; }
        }
        
        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        
        private Pagos pagos;

        public Pagos Pagos
        {
            get { return pagos; }
            set { pagos = value; }
        }
        
        private bool rindeExamen;

        public bool RindeExamen
        {
            get { return rindeExamen; }
            set { rindeExamen = value; }
        }
        
        private bool pagaMatricula;

        public bool PagaMatricula
        {
            get { return pagaMatricula; }
            set { pagaMatricula = value; }
        }       
        
        private Hermanos nombreHermano;

        public Hermanos NombreHermano
        {
            get { return nombreHermano; }
            set { nombreHermano = value; }
        }
        
        private FliaAutorizada nombreFliaAutorizada;

        public FliaAutorizada NombreFliaAutorizada
        {
            get { return nombreFliaAutorizada; }
            set { nombreFliaAutorizada = value; }
        }

        private int cantHermanos;

        public int CantHermanos
        {
            get { return cantHermanos; }
            set { cantHermanos = value; }
        }
    }
}
