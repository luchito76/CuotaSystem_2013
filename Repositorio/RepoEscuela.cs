using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Repositorio
{
    public class RepoEscuela
    {
        public void altaEscuela(Escuela escuela) {
            if (Conexion.conectar()) {
                SqlCommand cmdEscuela = new SqlCommand("altaEscuela", Conexion.conexion);
                cmdEscuela.CommandType = CommandType.StoredProcedure;

                cmdEscuela.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmdEscuela.Parameters.Add("@msg", SqlDbType.NVarChar, 100);

                cmdEscuela.Parameters["@msg"].Direction = ParameterDirection.Output;

                cmdEscuela.Parameters[0].Value = escuela.NombreEscuela;

                cmdEscuela.ExecuteNonQuery();

                string respuesta = cmdEscuela.Parameters["@msg"].Value.ToString();
                MessageBox.Show(respuesta);
            }
        }

        public List<Escuela> listadoDeEscuela() {
            List<Escuela> traeEscuela = new List<Escuela>();
            string queryEscuela = "select * from escuela";

            if (Conexion.conectar()) {
                DataTable dtEscuela = new DataTable();
                dtEscuela = Conexion.LeerTabla(queryEscuela);

                foreach (DataRow row in dtEscuela.Rows) {
                    Escuela escuela = new Escuela();

                    escuela.IdEscuela = Convert.ToInt16(row["idEscuela"]);
                    escuela.NombreEscuela = row["nombre"].ToString();
                    traeEscuela.Add(escuela);
                }
            }

            return traeEscuela;
        }
    }
}
