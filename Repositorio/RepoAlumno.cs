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
    public class RepoAlumno
    {
        public void AltaAlumnos(Alumnos alumno, Cursos curso) {
            if (Conexion.conectar()) {
                alumno.Curso = curso;

                SqlCommand cmdAlumno = new SqlCommand("altaAlumnos", Conexion.conexion);
                cmdAlumno.CommandType = CommandType.StoredProcedure;

                cmdAlumno.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmdAlumno.Parameters.Add("@apellido", SqlDbType.NVarChar);
                cmdAlumno.Parameters.Add("@nroMatricula", SqlDbType.Int);
                cmdAlumno.Parameters.Add("@direccion", SqlDbType.NVarChar);
                cmdAlumno.Parameters.Add("@dni", SqlDbType.Int);
                cmdAlumno.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
                cmdAlumno.Parameters.Add("@fechaInscripcion", SqlDbType.DateTime);
                cmdAlumno.Parameters.Add("@telefono", SqlDbType.Int);
                cmdAlumno.Parameters.Add("@idcurso", SqlDbType.Int);
                cmdAlumno.Parameters.Add("@mail", SqlDbType.NVarChar);
                cmdAlumno.Parameters.Add("@nomPadre", SqlDbType.NVarChar);
                cmdAlumno.Parameters.Add("@nomMadre", SqlDbType.NVarChar);
                cmdAlumno.Parameters.Add("@idEscuela", SqlDbType.Int);
                cmdAlumno.Parameters.Add("@turno", SqlDbType.NVarChar);                
                cmdAlumno.Parameters.Add("@planSanitaria", SqlDbType.Bit);
                cmdAlumno.Parameters.Add("@rindeExamen", SqlDbType.Bit);
                cmdAlumno.Parameters.Add("@pagaMatricula", SqlDbType.Bit);
                cmdAlumno.Parameters.Add("@cantHermanos", SqlDbType.Int);
                cmdAlumno.Parameters.Add("@activo", SqlDbType.Bit);
                cmdAlumno.Parameters.Add("@idGrupo", SqlDbType.Int);
                cmdAlumno.Parameters.Add("@grado", SqlDbType.NVarChar);
                cmdAlumno.Parameters.Add("@msg", SqlDbType.NVarChar, 100);

                cmdAlumno.Parameters["@msg"].Direction = ParameterDirection.Output;

                cmdAlumno.UpdatedRowSource = UpdateRowSource.None;
                cmdAlumno.Parameters[0].Value = alumno.Nombre;
                cmdAlumno.Parameters[1].Value = alumno.Apellido;
                cmdAlumno.Parameters[2].Value = alumno.NroMatricula;
                cmdAlumno.Parameters[3].Value = alumno.Direccion;
                cmdAlumno.Parameters[4].Value = alumno.Dni;
                cmdAlumno.Parameters[5].Value = alumno.FechaNacimiento;
                cmdAlumno.Parameters[6].Value = alumno.FechaInscripcion;
                cmdAlumno.Parameters[7].Value = alumno.Telefono;                
                cmdAlumno.Parameters[8].Value = alumno.Curso.IdCurso;
                cmdAlumno.Parameters[9].Value = alumno.Mail;
                cmdAlumno.Parameters[10].Value = alumno.NomPadre;
                cmdAlumno.Parameters[11].Value = alumno.NomMadre;
                cmdAlumno.Parameters[12].Value = alumno.Escuela.IdEscuela;
                cmdAlumno.Parameters[13].Value = alumno.Turno;
                cmdAlumno.Parameters[14].Value = alumno.PlanillaSanitaria;
                cmdAlumno.Parameters[15].Value = alumno.RindeExamen;
                cmdAlumno.Parameters[16].Value = alumno.PagaMatricula;
                cmdAlumno.Parameters[17].Value = alumno.CantHermanos;
                cmdAlumno.Parameters[18].Value = alumno.Activo;
                cmdAlumno.Parameters[19].Value = alumno.IdGrupoFamiliar;
                cmdAlumno.Parameters[20].Value = alumno.Grado;
                cmdAlumno.Parameters[21].Value = "";

                cmdAlumno.ExecuteNonQuery();

                string respuesta = cmdAlumno.Parameters["@msg"].Value.ToString();
                MessageBox.Show(respuesta);
                

                
            }
        }
    }
}
