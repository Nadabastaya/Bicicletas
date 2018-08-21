namespace Bicicletas
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarBicicletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedorToolStripMenuItem
            // 
            this.mantenedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarAlumnoToolStripMenuItem,
            this.consultarBicicletaToolStripMenuItem});
            this.mantenedorToolStripMenuItem.Name = "mantenedorToolStripMenuItem";
            this.mantenedorToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.mantenedorToolStripMenuItem.Text = "Mantenedor";
            // 
            // consultarAlumnoToolStripMenuItem
            // 
            this.consultarAlumnoToolStripMenuItem.Name = "consultarAlumnoToolStripMenuItem";
            this.consultarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.consultarAlumnoToolStripMenuItem.Text = "Consultar Alumno";
            this.consultarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.consultarAlumnoToolStripMenuItem_Click);
            // 
            // consultarBicicletaToolStripMenuItem
            // 
            this.consultarBicicletaToolStripMenuItem.Name = "consultarBicicletaToolStripMenuItem";
            this.consultarBicicletaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarBicicletaToolStripMenuItem.Text = "Consultar Bicicleta";
            this.consultarBicicletaToolStripMenuItem.Click += new System.EventHandler(this.consultarBicicletaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 545);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarBicicletaToolStripMenuItem;
    }
}

