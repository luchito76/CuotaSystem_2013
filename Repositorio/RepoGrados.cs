using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data;

namespace Repositorio
{
    public class RepoGrados
    {
        public List<GradosEscuela> listadoDeGrados() {
            List<GradosEscuela> traeGrados = new List<GradosEscuela>();

            string queryGrados = "select * from grados";

            if (Conexion.conectar()) {
                DataTable dtGrados = new DataTable();
                dtGrados = Conexion.LeerTabla(queryGrados);

                foreach (DataRow row in dtGrados.Rows) {
                    GradosEscuela grados = new GradosEscuela();
                    grados.IdGrados = Convert.ToInt16(row["idGrado"]);
                    grados.Descripcion = row["grado"].ToString();
                    traeGrados.Add(grados);
                }
            }

            return traeGrados;
        }
    }
}
