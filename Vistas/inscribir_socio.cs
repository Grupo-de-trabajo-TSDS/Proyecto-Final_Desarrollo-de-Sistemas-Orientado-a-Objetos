using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Vistas
{
    public partial class FrmInscribirSocio : Form
    {
        public FrmInscribirSocio()
        {
            InitializeComponent();
        }

        private void FrmInscribirSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Abrir frmPrincipal
            frmPrincipal inicio = new frmPrincipal();
            inicio.Show();

            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        }

        private void FrmInscribirSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
