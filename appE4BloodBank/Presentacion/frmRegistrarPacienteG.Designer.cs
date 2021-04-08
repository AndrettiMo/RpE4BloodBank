
namespace appE4BloodBank.Presentacion
{
    partial class frmRegistrarPacienteG
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
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.Label();
            this.TipoDocumento = new System.Windows.Forms.Label();
            this.FechaNacimiento = new System.Windows.Forms.Label();
            this.TipoSangre = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Gmail = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cmbTipoSangre = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(213, 343);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(212, 64);
            this.btnRegistrarse.TabIndex = 0;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(378, 56);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(47, 13);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Apellido ";
            // 
            // Documento
            // 
            this.Documento.AutoSize = true;
            this.Documento.Location = new System.Drawing.Point(41, 107);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(62, 13);
            this.Documento.TabIndex = 3;
            this.Documento.Text = "Documento";
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.AutoSize = true;
            this.TipoDocumento.Location = new System.Drawing.Point(378, 107);
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.Size = new System.Drawing.Size(83, 13);
            this.TipoDocumento.TabIndex = 4;
            this.TipoDocumento.Text = "TipoDocumento";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.AutoSize = true;
            this.FechaNacimiento.Location = new System.Drawing.Point(41, 167);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(90, 13);
            this.FechaNacimiento.TabIndex = 5;
            this.FechaNacimiento.Text = "FechaNacimiento";
            // 
            // TipoSangre
            // 
            this.TipoSangre.AutoSize = true;
            this.TipoSangre.Location = new System.Drawing.Point(378, 167);
            this.TipoSangre.Name = "TipoSangre";
            this.TipoSangre.Size = new System.Drawing.Size(62, 13);
            this.TipoSangre.TabIndex = 6;
            this.TipoSangre.Text = "TipoSangre";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(41, 235);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(49, 13);
            this.Telefono.TabIndex = 7;
            this.Telefono.Text = "Telefono";
            // 
            // Gmail
            // 
            this.Gmail.AutoSize = true;
            this.Gmail.Location = new System.Drawing.Point(378, 235);
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(32, 13);
            this.Gmail.TabIndex = 8;
            this.Gmail.Text = "Email";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "Tarjeta de  Identidad",
            "Cedula de Ciudadania"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(470, 104);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(181, 21);
            this.cmbTipoDocumento.TabIndex = 10;
            // 
            // cmbTipoSangre
            // 
            this.cmbTipoSangre.FormattingEnabled = true;
            this.cmbTipoSangre.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "AB+",
            "AB-"});
            this.cmbTipoSangre.Location = new System.Drawing.Point(508, 159);
            this.cmbTipoSangre.Name = "cmbTipoSangre";
            this.cmbTipoSangre.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoSangre.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(155, 228);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(181, 20);
            this.txtTelefono.TabIndex = 18;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(470, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(181, 20);
            this.txtApellido.TabIndex = 19;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(147, 100);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(181, 20);
            this.txtDocumento.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(470, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(147, 159);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(181, 20);
            this.txtFechaNacimiento.TabIndex = 22;
            // 
            // frmRegistrarPacienteG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoSangre);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.Gmail);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.TipoSangre);
            this.Controls.Add(this.FechaNacimiento);
            this.Controls.Add(this.TipoDocumento);
            this.Controls.Add(this.Documento);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarse);
            this.Name = "frmRegistrarPacienteG";
            this.Text = "frmRegistrarPacienteG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Documento;
        private System.Windows.Forms.Label TipoDocumento;
        private System.Windows.Forms.Label FechaNacimiento;
        private System.Windows.Forms.Label TipoSangre;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Gmail;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.ComboBox cmbTipoSangre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
    }
}