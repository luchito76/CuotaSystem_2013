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
using System.Globalization;

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
            txt_cuota.Text = curso.MontoCuota.ToString("C2");
            txt_matricula.Text = curso.Matricula.ValorMatricula.ToString("C2");
            txt_montoExamen.Text = curso.Examen.ValorExamen.ToString("C2");
            dtp_fInicio.Text = curso.FechaInicio.ToShortDateString();
            dtp_fFin.Text = curso.FechaFin.ToShortDateString();
            
            Funciones.etiqueta(lblActivo, curso.Activo);
           
        }

        private void FormModificarCurso_Load(object sender, EventArgs e)
        {
            ToolTip to = new ToolTip();
            to.SetToolTip(btn_cursos, "Aceptar");
            to.SetToolTip(btn_volver, "Volver");
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            NegoCursos negCurso = new NegoCursos();
            Cursos curso = new Cursos();
            Matricula matricula = new Matricula();
            Examen examen = new Examen();

            try
            {
                curso.Matricula = matricula;
                curso.Examen = examen;

                curso.IdCurso = Convert.ToInt16(lbl_idCurso.Text);
                curso.Descripcion = txt_descripcion.Text;
                curso.MontoCuota = Convert.ToDecimal(txt_cuota.Text);
                curso.Matricula.ValorMatricula = Funciones.ToDecimal(txt_matricula.Text);
                curso.Examen.ValorExamen = Funciones.ToDecimal(txt_montoExamen.Text);
                curso.FechaInicio = Convert.ToDateTime(dtp_fInicio.Text);
                curso.FechaFin = Convert.ToDateTime(dtp_fFin.Text);

                negCurso.modifCurso(curso);

                Funciones.limpiarCampos(grpModificarCurso, txt_descripcion);
            }
            catch (Exception ex) {
                MessageBox.Show("Se produjo un error al ingresar los datos. Recuerde que para poner decimales debe usr el punto.");
            }
        }       

        private void txt_cuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.campoSoloNumeros(e);
        }

        private void txt_matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.campoSoloNumeros(e);
        }

        private void txt_montoExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.campoSoloNumeros(e);
        }

        private void txt_cuota_Click(object sender, EventArgs e)
        {
            txt_cuota.Text = "";
        }

        private void txt_matricula_Click(object sender, EventArgs e)
        {
            txt_matricula.Text = "";
        }

        private void txt_montoExamen_Click(object sender, EventArgs e)
        {
            txt_montoExamen.Text = "";
        }

        
    }
}
