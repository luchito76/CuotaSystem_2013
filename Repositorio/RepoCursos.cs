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
    public class RepoCursos
    {
        public void altaCurso(Cursos curso) {
            if (Conexion.conectar()) {
                SqlCommand cmdCursos = new SqlCommand("altaCursos", Conexion.conexion);
                cmdCursos.CommandType = CommandType.StoredProcedure;

                cmdCursos.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmdCursos.Parameters.Add("@montoCuota", SqlDbType.Money);
                cmdCursos.Parameters.Add("@montoMatricula", SqlDbType.Money);
                cmdCursos.Parameters.Add("@montoExamen", SqlDbType.Money);
                cmdCursos.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
                cmdCursos.Parameters.Add("@fechaFin", SqlDbType.DateTime);
                cmdCursos.Parameters.Add("@msg", SqlDbType.NVarChar, 100);

                cmdCursos.Parameters["@msg"].Direction = ParameterDirection.Output;

                cmdCursos.Parameters[0].Value = curso.Descripcion;
                cmdCursos.Parameters[1].Value = curso.MontoCuota;
                cmdCursos.Parameters[2].Value = curso.Matricula.ValorMatricula;
                cmdCursos.Parameters[3].Value = curso.Examen.ValorExamen;
                cmdCursos.Parameters[4].Value = curso.FechaInicio;
                cmdCursos.Parameters[5].Value = curso.FechaFin;

                cmdCursos.ExecuteNonQuery();

                string respuesta = cmdCursos.Parameters["@msg"].Value.ToString();
                MessageBox.Show(respuesta);
            }
        }

        public void modificarCurso(Cursos curso) {
            if (Conexion.conectar())
            {
                SqlCommand cmd_modCursos = new SqlCommand("modificarCurso", Conexion.conexion);
                cmd_modCursos.CommandType = CommandType.StoredProcedure;

                cmd_modCursos.Parameters.Add("@idcurso", SqlDbType.Int);
                cmd_modCursos.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd_modCursos.Parameters.Add("@montoCuota", SqlDbType.Money);
                cmd_modCursos.Parameters.Add("@montoMatricula", SqlDbType.Money);
                cmd_modCursos.Parameters.Add("@fechaInicio", SqlDbType.DateTime);
                cmd_modCursos.Parameters.Add("@fechaFin", SqlDbType.DateTime);
                cmd_modCursos.Parameters.Add("@montoExamen", SqlDbType.Money);
                cmd_modCursos.Parameters.Add("@msg", SqlDbType.NVarChar, 100);

                cmd_modCursos.Parameters["@msg"].Direction = ParameterDirection.Output;

                cmd_modCursos.UpdatedRowSource = UpdateRowSource.None;
                cmd_modCursos.Parameters[0].Value = curso.IdCurso;
                cmd_modCursos.Parameters[1].Value = curso.Descripcion;
                cmd_modCursos.Parameters[2].Value = curso.MontoCuota;
                cmd_modCursos.Parameters[3].Value = curso.Matricula.ValorMatricula;
                cmd_modCursos.Parameters[4].Value = curso.FechaInicio;
                cmd_modCursos.Parameters[5].Value = curso.FechaFin; ;
                cmd_modCursos.Parameters[6].Value = curso.Examen.ValorExamen;
                cmd_modCursos.Parameters[7].Value = "";

                cmd_modCursos.ExecuteNonQuery();

                string respuesta = cmd_modCursos.Parameters["@msg"].Value.ToString();
                MessageBox.Show(respuesta);

            }
        }

        public List<Cursos> lidtadoDeCuros() {
            List<Cursos> traeCursos = new List<Cursos>();

            //string queryCursos = "select nombre, montoCuota, montoMatricula, montoExamen, fechaInicio, fechaFin from cursos";
            string queryCursos = "select * from cursos";

            if (Conexion.conectar()) {
                DataTable dtCasos = new DataTable();
                dtCasos = Conexion.LeerTabla(queryCursos);                
                
                foreach (DataRow row in dtCasos.Rows) {
                    Matricula matri = new Matricula();
                    Examen examen = new Examen();
                    Cursos curso = new Cursos();
                    curso.Matricula = matri;
                    curso.Examen = examen;


                    curso.IdCurso = Convert.ToInt16(row["idCurso"]);                    
                    curso.Descripcion = row["nombre"].ToString();
                    curso.MontoCuota = Convert.ToDecimal(row["montoCuota"]);
                    curso.Matricula.ValorMatricula = Convert.ToDecimal(row["montoMatricula"]);                    
                    curso.Examen.ValorExamen = Convert.ToDecimal(row["montoExamen"]);
                    curso.FechaInicio = Convert.ToDateTime(row["fechaInicio"]);
                    curso.FechaFin = Convert.ToDateTime(row["fechaFin"]);
                    curso.Activo = Convert.ToBoolean(row["activo"]);
                    
                    traeCursos.Add(curso);
                }
            }
            return traeCursos;
        }
    }
}
