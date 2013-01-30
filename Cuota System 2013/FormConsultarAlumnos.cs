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
    public partial class FormConsultarAlumnos : Form
    {
        public FormConsultarAlumnos()
        {
            InitializeComponent();
        }

        private void FormConsultarAlumnos_Load(object sender, EventArgs e)
        {
            NegoAlumno negAlumno = new NegoAlumno();
            dgvALumno.DataSource = negAlumno.listadoDeAlumnos();
        }
    }
}
