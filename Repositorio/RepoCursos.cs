﻿using System;
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
    }
}
