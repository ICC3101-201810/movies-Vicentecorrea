namespace VistasLab
{
    partial class VentanaPrincipal
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
            this.BotonPeliculas = new System.Windows.Forms.Button();
            this.BotonActores = new System.Windows.Forms.Button();
            this.BotonDirectores = new System.Windows.Forms.Button();
            this.BotonProductores = new System.Windows.Forms.Button();
            this.BotonEstudios = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonPeliculas
            // 
            this.BotonPeliculas.Location = new System.Drawing.Point(12, 57);
            this.BotonPeliculas.Name = "BotonPeliculas";
            this.BotonPeliculas.Size = new System.Drawing.Size(75, 23);
            this.BotonPeliculas.TabIndex = 0;
            this.BotonPeliculas.Text = "Peliculas";
            this.BotonPeliculas.UseVisualStyleBackColor = true;
            this.BotonPeliculas.Click += new System.EventHandler(this.BotonPeliculas_Click);
            this.BotonPeliculas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BotonPeliculas_MouseClick);
            // 
            // BotonActores
            // 
            this.BotonActores.Location = new System.Drawing.Point(93, 57);
            this.BotonActores.Name = "BotonActores";
            this.BotonActores.Size = new System.Drawing.Size(75, 23);
            this.BotonActores.TabIndex = 1;
            this.BotonActores.Text = "Actores";
            this.BotonActores.UseVisualStyleBackColor = true;
            this.BotonActores.Click += new System.EventHandler(this.BotonActores_Click);
            // 
            // BotonDirectores
            // 
            this.BotonDirectores.Location = new System.Drawing.Point(174, 57);
            this.BotonDirectores.Name = "BotonDirectores";
            this.BotonDirectores.Size = new System.Drawing.Size(75, 23);
            this.BotonDirectores.TabIndex = 2;
            this.BotonDirectores.Text = "Directores";
            this.BotonDirectores.UseVisualStyleBackColor = true;
            this.BotonDirectores.Click += new System.EventHandler(this.BotonDirectores_Click);
            // 
            // BotonProductores
            // 
            this.BotonProductores.Location = new System.Drawing.Point(255, 57);
            this.BotonProductores.Name = "BotonProductores";
            this.BotonProductores.Size = new System.Drawing.Size(75, 23);
            this.BotonProductores.TabIndex = 3;
            this.BotonProductores.Text = "Productores";
            this.BotonProductores.UseVisualStyleBackColor = true;
            this.BotonProductores.Click += new System.EventHandler(this.BotonProductores_Click);
            // 
            // BotonEstudios
            // 
            this.BotonEstudios.Location = new System.Drawing.Point(336, 57);
            this.BotonEstudios.Name = "BotonEstudios";
            this.BotonEstudios.Size = new System.Drawing.Size(75, 23);
            this.BotonEstudios.TabIndex = 4;
            this.BotonEstudios.Text = "Estudios";
            this.BotonEstudios.UseVisualStyleBackColor = true;
            this.BotonEstudios.Click += new System.EventHandler(this.BotonEstudios_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(299, 12);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(112, 20);
            this.BotonBuscar.TabIndex = 7;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 123);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BotonEstudios);
            this.Controls.Add(this.BotonProductores);
            this.Controls.Add(this.BotonDirectores);
            this.Controls.Add(this.BotonActores);
            this.Controls.Add(this.BotonPeliculas);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.VentanaPrincipal_FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonPeliculas;
        private System.Windows.Forms.Button BotonActores;
        private System.Windows.Forms.Button BotonDirectores;
        private System.Windows.Forms.Button BotonProductores;
        private System.Windows.Forms.Button BotonEstudios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BotonBuscar;
    }
}