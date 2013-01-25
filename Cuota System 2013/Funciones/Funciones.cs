using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Cuota_System_2013.Funciones
{
    public class Funciones
    {
        public void limpiarCampos(GroupBox caja, TextBox txt) {           
            foreach (Control c in caja.Controls)
            {
                if ((c is TextBox) || (c is ComboBox))
                {
                    c.Text = "";
                    txt.Focus();
                }
            }
            
        }
    }
}
