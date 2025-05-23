using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final.Vistas
{
    public partial class FrmInscribirNoSocio : Form
    {
        public FrmInscribirNoSocio()
        {
            InitializeComponent();
        }

        private void FrmInscribirNoSocio_Load(object sender, EventArgs e)
        {

            this.AutoValidate = AutoValidate.Disable;

        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            string dni = txtDniNoSocio.Text.Trim();
            if (dni != "")
            {
                if (NoSocio.ExisteNoSocioPorDNI(dni))
                {
                    MessageBox.Show("Este DNI ya está registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDniNoSocio.Clear();
                    txtDniNoSocio.Focus();
                }
            }
        }


        private void btnInscribir_Click(object sender, EventArgs e)
        {
            NoSocio nuevo = new NoSocio(
           
                txtDniNoSocio.Text.Trim(),
                txtApellidoNoSocio.Text.Trim(),
                txtNombreNoSocio.Text.Trim(),
                txtFechaNacimientoNoSocio.Text.ToString(),
                DateTime.Now.ToString("dd-MM-yyyy"),
                txtDireccionNoSocio.Text.Trim(),
                txtEmailNoSocio.Text.Trim(),
                txtTelefonoNoSocio.Text.Trim(),
                txtContactoUrgenciaNoSocio.Text.Trim(),
                txtFichaMedicaNoSocio.Text.Trim()                
            );

            bool guardado = NoSocio.inscripcionnosocio(nuevo);

            if (guardado)
            {
                MessageBox.Show("Inscripción exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmPrincipal().Show();
                this.Hide();
                  // O volvé al formulario principal como lo tengas definido
            }
            else
            {
                MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Abrir frmPrincipal
            frmPrincipal inicio = new frmPrincipal();
            inicio.Show();

            // Cerrar el formulario actual
            this.Hide(); // o this.Hide(); si querés solo ocultarlo
        }
        private void FrmInscribirNoSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarNoSocio_Click(object sender, EventArgs e)
        {
            
            Utilidades.LimpiarControles(this, txtDniNoSocio); // 'txtDni' es el control donde debe quedar el foco
        

        }
    }

}
