namespace WinAppSpotifyClone
{
    partial class FormMain
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
            this.cancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cancionToolStripMenuItem
            // 
            this.cancionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCancionToolStripMenuItem,
            this.crearCancionToolStripMenuItem,
            this.actualizarCancionToolStripMenuItem,
            this.eliminarCancionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.cancionToolStripMenuItem.ForeColor = System.Drawing.Color.BlueViolet;
            this.cancionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cancionToolStripMenuItem.Name = "cancionToolStripMenuItem";
            this.cancionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.cancionToolStripMenuItem.Text = "&Canciones";
            // 
            // consultarCancionToolStripMenuItem
            // 
            this.consultarCancionToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.consultarCancionToolStripMenuItem.Name = "consultarCancionToolStripMenuItem";
            this.consultarCancionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarCancionToolStripMenuItem.Text = "&Consultar Cancion";
            this.consultarCancionToolStripMenuItem.Click += new System.EventHandler(this.consultarCancionToolStripMenuItem_Click);
            // 
            // crearCancionToolStripMenuItem
            // 
            this.crearCancionToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.crearCancionToolStripMenuItem.Name = "crearCancionToolStripMenuItem";
            this.crearCancionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearCancionToolStripMenuItem.Text = "C&rear Cancion";
            this.crearCancionToolStripMenuItem.Click += new System.EventHandler(this.crearCancionToolStripMenuItem_Click);
            // 
            // actualizarCancionToolStripMenuItem
            // 
            this.actualizarCancionToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.actualizarCancionToolStripMenuItem.Name = "actualizarCancionToolStripMenuItem";
            this.actualizarCancionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarCancionToolStripMenuItem.Text = "&Actualizar Cancion";
            // 
            // eliminarCancionToolStripMenuItem
            // 
            this.eliminarCancionToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.eliminarCancionToolStripMenuItem.Name = "eliminarCancionToolStripMenuItem";
            this.eliminarCancionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarCancionToolStripMenuItem.Text = "&Eliminar Cancion";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.BlueViolet;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(476, 243);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "Song";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonFace;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}