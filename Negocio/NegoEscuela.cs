using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio;
using Dominio;

namespace Negocio
{
    public class NegoEscuela
    {
        RepoEscuela repEscuela = new RepoEscuela();

        public List<Escuela> listadoDeEscuelas() {
            return repEscuela.listadoDeEscuela();
        }
    }
}
