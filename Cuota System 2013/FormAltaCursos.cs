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
    public partial class FormAltaCursos : Form
    {
        public FormAltaCursos()
        {
            InitializeComponent();
        }
        NegoCursos negoCurso = new NegoCursos();

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            Matricula matricula = new Matricula();
            Examen examen = new Examen();

            curso.Matricula = matricula;
            curso.Examen = examen;

            curso.Descripcion = txt_descripcion.Text;
            curso.MontoCuota = Convert.ToDecimal(maskMontoCuota.Text);            
            curso.Matricula.ValorMatricula = Convert.ToDecimal(maskMontoMatricula.Text);            
            curso.Examen.ValorExamen = Convert.ToDecimal(maskMontoExamen.Text);
            curso.FechaInicio = Convert.ToDateTime(dtp_fInicio.Text);
            curso.FechaFin = Convert.ToDateTime(dtp_fFin.Text);
            
            negoCurso.crearCurso(curso);
                        
            Funciones.limpiarCampos(grp_altaCurso, txt_descripcion);
        }
        
        
        private void FormAltaCursos_Load(object sender, EventArgs e)
        {
            txt_descripcion.Focus();           
        }
    }
}
