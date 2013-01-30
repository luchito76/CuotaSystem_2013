using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Cuota_System_2013
{
    public partial class FormConsultarCurso : Form
    {
        public FormConsultarCurso()
        {
            InitializeComponent();
        }

        private void FormModificarCurso_Load(object sender, EventArgs e)
        {
            ToolTip to = new ToolTip();
            to.SetToolTip(btn_volver, "Volver");

            NegoCursos negCursos = new NegoCursos();
            dgv_modifCursos.DataSource = negCursos.listadoDeCursos();

           
            
        }

        private void dgv_modifCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursos curso = new Cursos();
            
            DataGridView data = new DataGridView();
            
            curso.Descripcion = dgv_modifCursos.CurrentRow.Cells["Descripcion"].Value.ToString();
            curso.MontoCuota = Convert.ToDecimal(dgv_modifCursos.CurrentRow.Cells["montoCuota"].Value);
            
            
            
            curso.Examen.ValorExamen = Convert.ToDecimal(dgv_modifCursos.CurrentRow.Cells[2].Value);
            curso.FechaInicio = Convert.ToDateTime(dgv_modifCursos.CurrentRow.Cells["fechaInicio"].Value);
            curso.FechaFin = Convert.ToDateTime(dgv_modifCursos.CurrentRow.Cells["fechaFin"].Value);

            FormModificarCurso modifCurso = new FormModificarCurso();
            modifCurso.modificarCurso(curso);

            this.Hide();
            modifCurso.Show();
        }
    }
}
