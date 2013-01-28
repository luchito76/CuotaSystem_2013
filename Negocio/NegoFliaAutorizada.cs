using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class NegoFliaAutorizada
    {
        public void altaFliarAutorizado(FliaAutorizada flia) {
            RepoFliaAutorizada repFlia = new RepoFliaAutorizada();
            repFlia.altaFliaUtorizada(flia);
        }
    }
}
