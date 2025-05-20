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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir frmInscribirNoSocio
            FrmInscribirNoSocio inicio = new FrmInscribirNoSocio();
            inicio.Show();

            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // Abrir frmPrincipal
            FrmInscribirSocio inicio = new FrmInscribirSocio();
            inicio.Show();

            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Abrir frmPrincipal
            frmLogin inicio = new frmLogin();
            inicio.Show();

            // Cerrar el formulario actual
            this.Close(); // o this.Hide(); si querés solo ocultarlo
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
