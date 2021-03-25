namespace appE4BloodBank.Presentacion
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.listasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donanteToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.personalMedicoToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // donanteToolStripMenuItem
            // 
            this.donanteToolStripMenuItem.Name = "donanteToolStripMenuItem";
            this.donanteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.donanteToolStripMenuItem.Text = "Donante";
            this.donanteToolStripMenuItem.Click += new System.EventHandler(this.donanteToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // personalMedicoToolStripMenuItem
            // 
            this.personalMedicoToolStripMenuItem.Name = "personalMedicoToolStripMenuItem";
            this.personalMedicoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.personalMedicoToolStripMenuItem.Text = "Personal medico";
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donantesToolStripMenuItem,
            this.pacientesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // donantesToolStripMenuItem
            // 
            this.donantesToolStripMenuItem.Name = "donantesToolStripMenuItem";
            this.donantesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.donantesToolStripMenuItem.Text = "Donantes";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 382);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
    }
}