using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Cuota_System_2013
{
    public partial class FormFliaAutorizada : Form
    {
        public FormFliaAutorizada()
        {
            InitializeComponent();
        }

        FliaAutorizada flia = new FliaAutorizada();
        Alumnos alumno = new Alumnos();
        NegoFliaAutorizada negFlia = new NegoFliaAutorizada();
        NegoAlumno negAlumnos = new NegoAlumno();

        private void btn_autorizados_Click(object sender, EventArgs e)
        {
            flia.Alumno = alumno;

            flia.Nombre = txt_nombre.Text;
            flia.Apellido = txt_apellido.Text;
            flia.Relacion = txt_Relacion.Text;
            flia.Dni = Convert.ToDecimal(txt_dni.Text);
            flia.TelefonoFijo = Convert.ToDecimal(txt_tel_fijo.Text);
            flia.TelefonoCelular = Convert.ToDecimal(txt_tel_celular.Text);
            flia.Alumno.IdAlumno = 33;
            
            negFlia.altaFliarAutorizado(flia);
            
        }

        public void mustraALumno() {
            cmb_alumno.DisplayMember = "nombreCompleto";
            cmb_alumno.ValueMember = "idAlumno";
            cmb_alumno.DataSource = negAlumnos.listadoDeAlumnos();      
        }

        private void FormFliaAutorizada_Load(object sender, EventArgs e)
        {
            mustraALumno();
        }
    }
}
