using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Final
{

    public static class Utilidades
    {
        public static void LimpiarControles(Control contenedor, Control primerControl = null)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                switch (ctrl)
                {
                    case TextBox txt:
                        txt.Text = txt.Tag?.ToString() ?? "";
                        break;

                    case ComboBox cbo:
                        cbo.SelectedIndex = -1;
                        break;

                    case DateTimePicker dtp:
                        dtp.Value = DateTime.Now;
                        break;

                    case CheckBox chk:
                        chk.Checked = false;
                        break;

                    case RadioButton rdo:
                        rdo.Checked = false;
                        break;

                    case ListBox lst:
                        lst.ClearSelected();
                        break;

                    case MaskedTextBox mtxt:
                        mtxt.Clear();
                        break;
                }

                // Si el control contiene otros controles (como GroupBox, Panel, TabPage), limpiar también los hijos
                if (ctrl.HasChildren)
                {
                    LimpiarControles(ctrl);
                }
            }

            // Opcional: enfocar el primer control
            primerControl?.Focus();
        }
    }
}

