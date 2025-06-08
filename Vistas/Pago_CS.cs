using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final.Vistas
{
    public partial class frmPagoCuotaSocial : Form
    {
        public frmPagoCuotaSocial()
        {
            InitializeComponent();
        }

        private void cboFormasDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFormasDePago.SelectedIndex = 0; // Selects "Item 1"
        }
    }
}
