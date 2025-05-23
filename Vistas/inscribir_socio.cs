using System;
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
           
            this.AutoValidate = AutoValidate.Disable;
        
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            string dni = txtDniSocio.Text.Trim();
            if (dni != "")
            {
                if (Socio.ExisteSocioPorDNI(dni))
                {
                    MessageBox.Show("Este DNI ya está registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDniSocio.Clear();
                    txtDniSocio.Focus();
                }
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
                Socio nuevo = new Socio(
                txtDniSocio.Text.Trim(),
                txtApellidoSocio.Text.Trim(),
                txtNombreSocio.Text.Trim(),
                txtFechaNacimientoSocio.Text.ToString(),
                DateTime.Now.ToString("dd/MM/yyyy"),
                txtDireccionSocio.Text.Trim(),
                txtEmailSocio.Text.Trim(),
                txtTelefonoSocio.Text.Trim(),
                txtContactoUrgenciaSocio.Text.Trim(),
                txtFichaMedicaSocio.Text.Trim(),
                bool.Parse("true")
            );

            bool guardado = Socio.inscripcionsocio(nuevo);

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

        private void FrmInscribirSocio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiarSocio_Click(object sender, EventArgs e)
        {
        
            Utilidades.LimpiarControles(this, txtDniSocio); // 'txtDni' es el control donde debe quedar el foco
        

        }
    }
}
