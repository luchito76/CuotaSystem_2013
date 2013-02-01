using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace Cuota_System_2013
{
    static class Funciones
    {
        /// <summary>
        /// Limpia todos los campos.
        /// </summary>
        /// <param name="caja"></param>
        /// <param name="txt"></param>
        public static void limpiarCampos(GroupBox caja, TextBox txt)
        {
            foreach (Control c in caja.Controls)
            {
                if ((c is TextBox) || (c is ComboBox) || (c is MaskedTextBox))
                {
                    c.Text = "";
                    txt.Focus();
                }
            }

        }

        /// <summary>
        /// Valida que un campo sea de solo números y no se pueda ingresar caracteres alfanuméricos.
        /// </summary>
        /// <param name="e"></param>
        public static void campoSoloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 46))
            {
                e.Handled = true;                
            }
        }

        /// <summary>
        /// Convierte un String en Decimal.
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static decimal ToDecimal(string Value)
        {
            if (Value.Length == 0)
                return 0;
            else
                return Decimal.Parse(Value.Replace(" ", ""), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol);
        }

        public static void etiqueta(Label label, bool activo) {
            if (activo == true)
            {
                label.BackColor = Color.Green;
                label.Text = "Activo";
            }
            else {
                label.BackColor = Color.Red;
                label.Text = "Inactivo";
            }
            
        }

    }
}
