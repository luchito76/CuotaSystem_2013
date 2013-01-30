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
            dgv_consCursos.Columns[2].DefaultCellStyle.Format = "C2";
            
            formatoValorEnPesos();
        }

        private void dgv_consCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursos curso = new Cursos();
            Matricula matricula = new Matricula();
            curso.Matricula = matricula;

            curso.IdCurso = Convert.ToInt32(dgv_consCursos.CurrentRow.Cells["idCurso"].Value);
            curso.Descripcion = dgv_consCursos.CurrentRow.Cells["Descripcion"].Value.ToString();
            curso.MontoCuota = Convert.ToDecimal(dgv_consCursos.CurrentRow.Cells["MontoCuota"].Value);
            curso.Matricula.ValorMatricula = Convert.ToDecimal(dgv_consCursos.CurrentRow.Cells[6].Value);

            FormModificarCurso modCurso = new FormModificarCurso();
            modCurso.modifCurso(curso);

            this.Hide();
            modCurso.Show();
        }
    }
}
