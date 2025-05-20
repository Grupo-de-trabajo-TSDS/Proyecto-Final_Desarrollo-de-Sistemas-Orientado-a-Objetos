using System;
using System.Windows.Forms;

namespace Proyecto_Final.Vistas
{
    partial class FrmInscribirSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVolverSocio = new System.Windows.Forms.Button();
            this.btnInscribirSocio = new System.Windows.Forms.Button();
            this.btnLimpiarSocio = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDniSocio = new System.Windows.Forms.TextBox();
            this.txtFechaNacimientoSocio = new System.Windows.Forms.TextBox();
            this.txtContactoUrgenciaSocio = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtApellidoSocio = new System.Windows.Forms.TextBox();
            this.txtInscripcionSocio = new System.Windows.Forms.TextBox();
            this.txtDireccionSocio = new System.Windows.Forms.TextBox();
            this.txtEmailSocio = new System.Windows.Forms.TextBox();
            this.txtTelefonoSocio = new System.Windows.Forms.TextBox();
            this.txtFichaMedicaSocio = new System.Windows.Forms.TextBox();
            this.lblTitleSocio = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnVolverSocio, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInscribirSocio, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLimpiarSocio, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(198, 275);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 36);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnVolverSocio
            // 
            this.btnVolverSocio.Location = new System.Drawing.Point(165, 3);
            this.btnVolverSocio.Name = "btnVolverSocio";
            this.btnVolverSocio.Size = new System.Drawing.Size(74, 23);
            this.btnVolverSocio.TabIndex = 2;
            this.btnVolverSocio.Text = "VOLVER";
            this.btnVolverSocio.UseVisualStyleBackColor = true;
            this.btnVolverSocio.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnInscribirSocio
            // 
            this.btnInscribirSocio.Location = new System.Drawing.Point(84, 3);
            this.btnInscribirSocio.Name = "btnInscribirSocio";
            this.btnInscribirSocio.Size = new System.Drawing.Size(74, 23);
            this.btnInscribirSocio.TabIndex = 1;
            this.btnInscribirSocio.Text = "INSCRIBIR";
            this.btnInscribirSocio.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarSocio
            // 
            this.btnLimpiarSocio.Location = new System.Drawing.Point(3, 3);
            this.btnLimpiarSocio.Name = "btnLimpiarSocio";
            this.btnLimpiarSocio.Size = new System.Drawing.Size(74, 23);
            this.btnLimpiarSocio.TabIndex = 0;
            this.btnLimpiarSocio.Text = "LIMPIAR";
            this.btnLimpiarSocio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.txtDniSocio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFechaNacimientoSocio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtContactoUrgenciaSocio, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreSocio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtApellidoSocio, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInscripcionSocio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDireccionSocio, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailSocio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefonoSocio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFichaMedicaSocio, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 204);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // txtDniSocio
            // 
            this.txtDniSocio.Location = new System.Drawing.Point(3, 3);
            this.txtDniSocio.Multiline = true;
            this.txtDniSocio.Name = "txtDniSocio";
            this.txtDniSocio.Size = new System.Drawing.Size(136, 23);
            this.txtDniSocio.TabIndex = 7;
            this.txtDniSocio.Text = "DNI";
            this.txtDniSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFechaNacimientoSocio
            // 
            this.txtFechaNacimientoSocio.Location = new System.Drawing.Point(3, 54);
            this.txtFechaNacimientoSocio.Multiline = true;
            this.txtFechaNacimientoSocio.Name = "txtFechaNacimientoSocio";
            this.txtFechaNacimientoSocio.Size = new System.Drawing.Size(136, 23);
            this.txtFechaNacimientoSocio.TabIndex = 11;
            this.txtFechaNacimientoSocio.Text = "FECHA NACIMIENTO";
            // 
            // txtContactoUrgenciaSocio
            // 
            this.txtContactoUrgenciaSocio.Location = new System.Drawing.Point(343, 105);
            this.txtContactoUrgenciaSocio.Multiline = true;
            this.txtContactoUrgenciaSocio.Name = "txtContactoUrgenciaSocio";
            this.txtContactoUrgenciaSocio.Size = new System.Drawing.Size(136, 23);
            this.txtContactoUrgenciaSocio.TabIndex = 12;
            this.txtContactoUrgenciaSocio.Text = "CONTACTO URGENCIA";
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(173, 3);
            this.txtNombreSocio.Multiline = true;
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(136, 23);
            this.txtNombreSocio.TabIndex = 14;
            this.txtNombreSocio.Text = "NOMBRE";
            this.txtNombreSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellidoSocio
            // 
            this.txtApellidoSocio.Location = new System.Drawing.Point(343, 3);
            this.txtApellidoSocio.Multiline = true;
            this.txtApellidoSocio.Name = "txtApellidoSocio";
            this.txtApellidoSocio.Size = new System.Drawing.Size(136, 23);
            this.txtApellidoSocio.TabIndex = 13;
            this.txtApellidoSocio.Text = "APELLIDO";
            this.txtApellidoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInscripcionSocio
            // 
            this.txtInscripcionSocio.Location = new System.Drawing.Point(173, 54);
            this.txtInscripcionSocio.Multiline = true;
            this.txtInscripcionSocio.Name = "txtInscripcionSocio";
            this.txtInscripcionSocio.Size = new System.Drawing.Size(136, 23);
            this.txtInscripcionSocio.TabIndex = 16;
            this.txtInscripcionSocio.Text = "FECHA INSCRIPCIÓN";
            // 
            // txtDireccionSocio
            // 
            this.txtDireccionSocio.Location = new System.Drawing.Point(343, 54);
            this.txtDireccionSocio.Multiline = true;
            this.txtDireccionSocio.Name = "txtDireccionSocio";
            this.txtDireccionSocio.Size = new System.Drawing.Size(136, 23);
            this.txtDireccionSocio.TabIndex = 15;
            this.txtDireccionSocio.Text = "DIRECCIÓN";
            // 
            // txtEmailSocio
            // 
            this.txtEmailSocio.Location = new System.Drawing.Point(3, 105);
            this.txtEmailSocio.Multiline = true;
            this.txtEmailSocio.Name = "txtEmailSocio";
            this.txtEmailSocio.Size = new System.Drawing.Size(136, 23);
            this.txtEmailSocio.TabIndex = 17;
            this.txtEmailSocio.Text = "EMAIL";
            // 
            // txtTelefonoSocio
            // 
            this.txtTelefonoSocio.Location = new System.Drawing.Point(173, 105);
            this.txtTelefonoSocio.Multiline = true;
            this.txtTelefonoSocio.Name = "txtTelefonoSocio";
            this.txtTelefonoSocio.Size = new System.Drawing.Size(136, 23);
            this.txtTelefonoSocio.TabIndex = 18;
            this.txtTelefonoSocio.Text = "TELÉFONO";
            // 
            // txtFichaMedicaSocio
            // 
            this.txtFichaMedicaSocio.Location = new System.Drawing.Point(173, 156);
            this.txtFichaMedicaSocio.Multiline = true;
            this.txtFichaMedicaSocio.Name = "txtFichaMedicaSocio";
            this.txtFichaMedicaSocio.Size = new System.Drawing.Size(136, 23);
            this.txtFichaMedicaSocio.TabIndex = 19;
            this.txtFichaMedicaSocio.Text = "FICHA MÉDICA";
            // 
            // lblTitleSocio
            // 
            this.lblTitleSocio.AutoSize = true;
            this.lblTitleSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSocio.Location = new System.Drawing.Point(192, 15);
            this.lblTitleSocio.Name = "lblTitleSocio";
            this.lblTitleSocio.Size = new System.Drawing.Size(249, 31);
            this.lblTitleSocio.TabIndex = 10;
            this.lblTitleSocio.Text = "INSCRIBIR SOCIO";
            // 
            // FrmInscribirSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 327);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitleSocio);
            this.Name = "FrmInscribirSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscribir Socio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInscribirSocio_FormClosed);
            this.Load += new System.EventHandler(this.FrmInscribirSocio_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVolverSocio;
        private System.Windows.Forms.Button btnInscribirSocio;
        private System.Windows.Forms.Button btnLimpiarSocio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDniSocio;
        private System.Windows.Forms.TextBox txtFechaNacimientoSocio;
        private System.Windows.Forms.TextBox txtContactoUrgenciaSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtApellidoSocio;
        private System.Windows.Forms.TextBox txtInscripcionSocio;
        private System.Windows.Forms.TextBox txtDireccionSocio;
        private System.Windows.Forms.TextBox txtEmailSocio;
        private System.Windows.Forms.TextBox txtTelefonoSocio;
        private System.Windows.Forms.TextBox txtFichaMedicaSocio;
        private System.Windows.Forms.Label lblTitleSocio;
    }
}