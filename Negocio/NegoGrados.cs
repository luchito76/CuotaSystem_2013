using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio;
using Dominio;

namespace Negocio
{
    public class NegoGrados
    {
        RepoGrados repGrados = new RepoGrados();

        public List<GradosEscuela> listadoDeGrados() {
            return repGrados.listadoDeGrados();
        }
    }
}
