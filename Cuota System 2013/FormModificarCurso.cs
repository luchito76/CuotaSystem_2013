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

        public void modificarCurso(Cursos curso) {
            lbl_idCurso.Text = curso.IdCurso.ToString();
            txt_descripcion.Text = curso.Descripcion;
            txt_cuota.Text = curso.MontoCuota.ToString();
            txt_matricula.Text = curso.Matricula.ValorMatricula.ToString();
            dtp_fInicio.Text = curso.FechaFin.ToShortDateString();
            dtp_fFin.Text = curso.FechaFin.ToShortDateString();
            txt_montoExamen.Text = curso.Examen.ValorExamen.ToString();            
        }

        private void FormModificarCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
