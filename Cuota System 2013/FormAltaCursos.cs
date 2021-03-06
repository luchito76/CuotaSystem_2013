﻿using System;
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


            curso.Descripcion = txt_descripcion.Text;
            curso.MontoCuota = Convert.ToDecimal(txt_cuota.Text);
            curso.Matricula = matricula;
            curso.Matricula.ValorMatricula = Convert.ToDecimal(txt_matricula.Text);
            curso.Examen = examen;
            curso.Examen.ValorExamen = Convert.ToDecimal(txt_montoExamen.Text);
            curso.FechaInicio = Convert.ToDateTime(dtp_fInicio.Text);
            curso.FechaFin = Convert.ToDateTime(dtp_fFin.Text);
            
            negoCurso.crearCurso(curso);

            Funciones.Funciones limpiar = new Funciones.Funciones();
            limpiar.limpiarCampos(grp_altaCurso, txt_descripcion);
        }
        
        
        private void FormAltaCursos_Load(object sender, EventArgs e)
        {
            txt_descripcion.Focus();           
        }
    }
}
