using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class NegoCursos
    {
        RepoCursos repCurso = new RepoCursos();

        public void crearCurso(Cursos curso) {            
            repCurso.altaCurso(curso);
        }

        public List<Cursos> listadoDeCursos() {
            return repCurso.lidtadoDeCuros();
        }
    }
}
