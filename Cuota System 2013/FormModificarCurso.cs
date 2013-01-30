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
    public partial class FormModificarCurso : Form
    {
        public FormModificarCurso()
        {
            InitializeComponent();
        }

        public void modifCurso(Cursos curso) {
            lbl_idCurso.Text = curso.IdCurso.ToString();
            txt_descripcion.Text = curso.Descripcion; 
        }

        private void FormModificarCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
