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
    public partial class FormAltaAlumno : Form
    {
        public FormAltaAlumno()
        {
            InitializeComponent();
        }

        NegoAlumno negAlumno = new NegoAlumno();
        NegoCursos negCurso = new NegoCursos();
        NegoEscuela negEscuela = new NegoEscuela();
        NegoGrados negGrados = new NegoGrados();

        private void FormAltaAlumno_Load(object sender, EventArgs e)
        {
            datosIniciales();
            toolTips();

            muestraCursos();
            muestraEscuelas();
            muestraGrados();            
        }
        
        public void muestraCursos() {
            cmb_curso.DisplayMember = "Descripcion";
            cmb_curso.ValueMember = "IdCurso";
            cmb_curso.DataSource = negCurso.listadoDeCursos();
        }

        public void muestraEscuelas() {
            cmb_escuela.DisplayMember = "nombreEscuela";
            cmb_escuela.ValueMember = "idEscuela";
            cmb_escuela.DataSource = negEscuela.listadoDeEscuelas();
        }

        public void muestraGrados() {
            cmb_año_en_curso.DisplayMember = "descripcion";
            cmb_año_en_curso.ValueMember = "IdGrados";
            cmb_año_en_curso.DataSource = negGrados.listadoDeGrados();
        }

        private int compruebaRadioButton(RadioButton check) {
            if (check.Checked)
            {
                return 1;
            }
            else {
                return 0;
            }
        }


        private int cuentaHermanos() {
            return 0;
        }

        public int generaMatricula() {
            return negAlumno.generaNroMatricula();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            Cursos curso = new Cursos();
            Escuela escuela = new Escuela();
            GradosEscuela grados = new GradosEscuela();

            alumno.Curso = curso;
            alumno.Escuela = escuela;
            alumno.Grado = grados;
            
            alumno.Nombre = txt_nombre.Text;
            alumno.Apellido = txt_apellido.Text;
            alumno.NroMatricula = negAlumno.generaNroMatricula();
            alumno.Dni = Convert.ToInt32(txt_dni.Text);
            alumno.Telefono = Convert.ToDouble(txt_telefono.Text);
            alumno.Mail = txt_mail.Text;
            alumno.Direccion = txt_direccion.Text;
            alumno.Escuela.IdEscuela = Convert.ToInt16(cmb_escuela.SelectedValue);
            alumno.Turno = cmb_turno.SelectedItem.ToString();
            alumno.Grado.IdGrados = Convert.ToInt16(cmb_año_en_curso.SelectedValue);
            alumno.NomPadre = txt_nomPadre.Text;
            alumno.NomMadre = txt_nomMadre.Text;
            alumno.FechaInscripcion = DateTime.Today;
            alumno.FechaNacimiento = DateTime.Today;
            alumno.Curso.IdCurso = Convert.ToInt16(cmb_curso.SelectedValue);
            alumno.PlanillaSanitaria = Convert.ToBoolean(compruebaRadioButton(rbt_SI));
            alumno.RindeExamen = Convert.ToBoolean(compruebaRadioButton(rbt_rinde_SI));
            alumno.PagaMatricula = Convert.ToBoolean(compruebaRadioButton(rbt_matrSI));
            alumno.Activo = true; //Al darse de alta el alumno queda activ por defecto.
            alumno.CantHermanos = cuentaHermanos();
            alumno.IdGrupoFamiliar = 1;
            
            negAlumno.altaALumno(alumno);
           
            Funciones.limpiarCampos(groupBox1, txt_nombre);
            Funciones.limpiarCampos(grp_datosEspeciales, txt_nombre);
        }

        private void datosIniciales() {
            txt_nombre.Focus();
            txt_dni.MaxLength = 9;
            txt_telefono.MaxLength = 11;
            rbt_no.Checked = true;
            rbt_rinde_NO.Checked = true;
            rbt_matrNO.Checked = true;
            cmb_turno.Items.Add("Mañana");
            cmb_turno.Items.Add("Tarde");
            cmb_turno.SelectedIndex = cmb_turno.FindStringExact("Mañana");
            cmb_hermanos.Enabled = false;
            btn_acepHermanos.Enabled = false;
            grp_datosEspeciales.Hide();

            grp_datosEspeciales.Hide();

            DateTime dt = DateTime.Today;
            lbl_fecha_inscripcion.Text = dt.ToString();
        }

        private void toolTips() {
            ToolTip to = new ToolTip();
            to.SetToolTip(btn_acepHermanos, "Relacionar Hermano");
            to.SetToolTip(btn_aceptar, "Aceptar");
            to.SetToolTip(btn_volver, "Volver");
            to.SetToolTip(btn_cancelar, "Cancelar");
        }        

        private void dtp_fecha_nac_Leave_1(object sender, EventArgs e)
        {
            cmb_turno.SelectedItem = -1;

            DateTime fechaNac;
            DateTime hoy;
            int total = 0;
            int anos = 18;

            hoy = DateTime.Today;
            fechaNac = Convert.ToDateTime(dtp_fecha_nac.Value.ToShortDateString());
            TimeSpan edad = hoy - fechaNac;
            total = edad.Days;
            anos = total / 365;
            
            if (anos < 18)
            {
                grp_datosEspeciales.Show();                
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            chk_alEspecial.Checked = false;
            grp_aluEspecial.Size = new Size(135, 60);
            txt_valExaFinal.Text = "";
            txt_valHora.Text = "";
                        
            Funciones.limpiarCampos(groupBox1, txt_nombre);
            Funciones.limpiarCampos(grp_datosEspeciales, txt_nombre);            
        }        

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.campoSoloNumeros(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.campoSoloNumeros(e);
        }
        
    }
}
