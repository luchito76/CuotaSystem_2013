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
    public class RepoFliaAutorizada
    {
        public void altaFliaUtorizada(FliaAutorizada flia) {
            if (Conexion.conectar()) {
                SqlCommand cmdFliaAutorizada = new SqlCommand("altaFliaAutorizada", Conexion.conexion);
                cmdFliaAutorizada.CommandType = CommandType.StoredProcedure;

                cmdFliaAutorizada.Parameters.Add("@nombre", SqlDbType.NVarChar);                
                cmdFliaAutorizada.Parameters.Add("@relacion", SqlDbType.NVarChar);
                cmdFliaAutorizada.Parameters.Add("@dni", SqlDbType.Decimal);
                cmdFliaAutorizada.Parameters.Add("@telFijo", SqlDbType.Decimal);
                cmdFliaAutorizada.Parameters.Add("@telCelular", SqlDbType.Decimal);
                cmdFliaAutorizada.Parameters.Add("@idAlumno", SqlDbType.Int);
                cmdFliaAutorizada.Parameters.Add("@apellido", SqlDbType.NVarChar);
                cmdFliaAutorizada.Parameters.Add("@msg", SqlDbType.NVarChar, 100);

                cmdFliaAutorizada.Parameters["@msg"].Direction = ParameterDirection.Output;

                cmdFliaAutorizada.Parameters[0].Value = flia.Nombre;                
                cmdFliaAutorizada.Parameters[1].Value = flia.Relacion;
                cmdFliaAutorizada.Parameters[2].Value = flia.Dni;
                cmdFliaAutorizada.Parameters[3].Value = flia.TelefonoFijo;
                cmdFliaAutorizada.Parameters[4].Value = flia.TelefonoCelular;
                cmdFliaAutorizada.Parameters[5].Value = flia.Alumno.IdAlumno;
                cmdFliaAutorizada.Parameters[6].Value = flia.Apellido;
                cmdFliaAutorizada.ExecuteNonQuery();

                string respuesta = cmdFliaAutorizada.Parameters["@msg"].Value.ToString();
                MessageBox.Show(respuesta);
            }
        }
    }
}
