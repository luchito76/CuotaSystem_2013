using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Configuration.Assemblies;

namespace Repositorio
{
    public class Conexion
    {
        //public static string parametro = "DATA SOURCE = FANTASIA\\SQLEXPRESS1; Initial Catalog = cuotas2013; Integrated Security = yes";
        public static string parametro = ConfigurationManager.ConnectionStrings["parametro"].ConnectionString;
        

        public static SqlConnection conexion;


        public static bool conectar()
        {


            bool conectado = false;

            conexion = new SqlConnection(parametro);

            try
            {

                conexion.Open();

                conectado = true;

            }

            catch (Exception error)
            {

                conectado = false;

            }

            return conectado;

        }

        public static void cerrar()
        {
            conexion.Close();
        }

        public static DataTable LeerTabla(string consulta)
        {

            DataTable dtresultado = null;

            if (conectar())
            {

                SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tabla");


                dtresultado = datos.Tables["tabla"];

            }

            return dtresultado;

        }



        public static void capturarTabla(string consulta)
        {

            if (conectar())
            {

                SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tabla");


            }
            else
            {
                MessageBox.Show("No se puede conectar!");
            }


        }

        public static DataTable TotalTabla(string consulta)
        {

            DataTable dtresultado = null;

            if (conectar())
            {

                SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                DataSet datos = new DataSet();

                adaptador.Fill(datos, "tabla");


                dtresultado = datos.Tables["tabla"];

            }

            return dtresultado;

        }
    }
}
