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
    public partial class FormConsultarCurso : Form 
    {
        public FormConsultarCurso()
        {
            InitializeComponent();
        }

        public void formatoValorEnPesos() {            
            dgv_consCursos.Columns["Matricula"].DefaultCellStyle.Format = "C2";
        }

        private void FormConsultarCurso_Load(object sender, EventArgs e)
        {
            NegoCursos negCursos = new NegoCursos();
            dgv_consCursos.DataSource = negCursos.listadoDeCursos();            
            
            formatoValorEnPesos();
        }

        private void dgv_consCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursos curso = new Cursos();
            Matricula matricula = new Matricula();
            Examen examen = new Examen();
            
            curso.Matricula = matricula;
            curso.Examen = examen;
            
            curso.IdCurso = Convert.ToInt32(dgv_consCursos.CurrentRow.Cells["idCurso"].Value);
            curso.Descripcion = dgv_consCursos.CurrentRow.Cells["Descripcion"].Value.ToString();
            curso.MontoCuota = Convert.ToDecimal(dgv_consCursos.CurrentRow.Cells["MontoCuota"].Value);
            curso.Matricula.ValorMatricula = Funciones.ToDecimal(dgv_consCursos.Rows[e.RowIndex].Cells["Matricula"].Value.ToString());
            curso.Examen.ValorExamen = Funciones.ToDecimal(dgv_consCursos.Rows[e.RowIndex].Cells["Examen"].Value.ToString());
            curso.FechaInicio = Convert.ToDateTime(dgv_consCursos.CurrentRow.Cells["fechaInicio"].Value);
            curso.FechaFin = Convert.ToDateTime(dgv_consCursos.CurrentRow.Cells["fechaFin"].Value); 

            FormModificarCurso modCurso = new FormModificarCurso();
            modCurso.modifCurso(curso);
            
            this.Hide();
            modCurso.Show();
        }        
    }
}
