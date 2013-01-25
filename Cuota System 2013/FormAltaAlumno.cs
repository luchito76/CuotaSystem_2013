using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Repositorio;

namespace Cuota_System_2013
{
    public partial class FormAltaAlumno : Form
    {
        public FormAltaAlumno()
        {
            InitializeComponent();
        }

        private void FormAltaAlumno_Load(object sender, EventArgs e)
        {
            datosIniciales();
            toolTips();
        }

        private int tienePlanillaSanitaria(RadioButton check) {
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

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            Cursos cur = new Cursos();
            Escuela escuela = new Escuela();
            RepoAlumno repoALumno = new RepoAlumno();

            alumno.Nombre = txt_nombre.Text;
            alumno.Apellido = txt_apellido.Text;
            alumno.NroMatricula = 1;
            alumno.Dni = Convert.ToInt32(txt_dni.Text);
            alumno.Telefono = Convert.ToInt32(txt_telefono.Text);
            alumno.Mail = txt_mail.Text;
            alumno.Direccion = txt_direccion.Text;
            alumno.Escuela = escuela;
            alumno.Escuela.IdEscuela = 1;
            alumno.Turno = "Tarde";
            alumno.Grado = "5 grado";
            alumno.NomPadre = txt_nomPadre.Text;
            alumno.NomMadre = txt_nomMadre.Text;
            alumno.FechaInscripcion = DateTime.Today;
            alumno.FechaNacimiento = DateTime.Today;
            cur.IdCurso = 1;
            alumno.PlanillaSanitaria = Convert.ToBoolean(tienePlanillaSanitaria(rbt_SI));
            alumno.RindeExamen = Convert.ToBoolean(tienePlanillaSanitaria(rbt_rinde_SI));
            alumno.PagaMatricula = Convert.ToBoolean(tienePlanillaSanitaria(rbt_matrSI));
            alumno.Activo = true; //Al darse de alta el alumno queda activ por defecto.
            alumno.CantHermanos = cuentaHermanos();
            alumno.IdGrupoFamiliar = 1;

            repoALumno.AltaAlumnos(alumno, cur);

            Funciones.Funciones limpiar = new Funciones.Funciones();
            limpiar.limpiarCampos(groupBox1, txt_nombre);
            limpiar.limpiarCampos(grp_datosEspeciales, txt_nombre);
        }

        private void datosIniciales() {
            txt_nombre.Focus();
            txt_dni.MaxLength = 9;
            txt_telefono.MaxLength = 10;
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
            MessageBox.Show("Años " + anos.ToString());
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

            Funciones.Funciones limpiar = new Funciones.Funciones();
            limpiar.limpiarCampos(groupBox1, txt_nombre);
            limpiar.limpiarCampos(grp_datosEspeciales, txt_nombre);            
        }

        private void campoSoloNumeros(KeyPressEventArgs e) {
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            campoSoloNumeros(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            campoSoloNumeros(e);
        }
    }
}
