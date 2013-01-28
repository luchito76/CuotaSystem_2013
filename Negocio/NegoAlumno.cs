using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorio;
using System.Data;

namespace Negocio
{
    public class NegoAlumno
    {
        RepoAlumno repAlumno = new RepoAlumno();

        public void altaALumno(Alumnos alumno) {
            
            repAlumno.AltaAlumnos(alumno);
        }

        public List<Alumnos> listadoDeAlumnos() {
            return repAlumno.listadoDeAlumnos();   
        }

        public int generaNroMatricula() {
            int nroMatricula = 0;
            nroMatricula = repAlumno.generaMatricula() + 1;
            return nroMatricula;
        }
    }
}
