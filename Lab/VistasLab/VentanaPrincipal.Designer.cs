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
            this.components = new System.ComponentModel.Container();
            this.BotonPeliculas = new System.Windows.Forms.Button();
            this.BotonActores = new System.Windows.Forms.Button();
            this.BotonDirectores = new System.Windows.Forms.Button();
            this.BotonProductores = new System.Windows.Forms.Button();
            this.BotonEstudios = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BotonPeliculas
            // 
            this.BotonPeliculas.Location = new System.Drawing.Point(197, 266);
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
            this.BotonActores.Location = new System.Drawing.Point(278, 266);
            this.BotonActores.Name = "BotonActores";
            this.BotonActores.Size = new System.Drawing.Size(75, 23);
            this.BotonActores.TabIndex = 1;
            this.BotonActores.Text = "Actores";
            this.BotonActores.UseVisualStyleBackColor = true;
            // 
            // BotonDirectores
            // 
            this.BotonDirectores.Location = new System.Drawing.Point(359, 266);
            this.BotonDirectores.Name = "BotonDirectores";
            this.BotonDirectores.Size = new System.Drawing.Size(75, 23);
            this.BotonDirectores.TabIndex = 2;
            this.BotonDirectores.Text = "Directores";
            this.BotonDirectores.UseVisualStyleBackColor = true;
            // 
            // BotonProductores
            // 
            this.BotonProductores.Location = new System.Drawing.Point(440, 266);
            this.BotonProductores.Name = "BotonProductores";
            this.BotonProductores.Size = new System.Drawing.Size(75, 23);
            this.BotonProductores.TabIndex = 3;
            this.BotonProductores.Text = "Productores";
            this.BotonProductores.UseVisualStyleBackColor = true;
            // 
            // BotonEstudios
            // 
            this.BotonEstudios.Location = new System.Drawing.Point(521, 266);
            this.BotonEstudios.Name = "BotonEstudios";
            this.BotonEstudios.Size = new System.Drawing.Size(75, 23);
            this.BotonEstudios.TabIndex = 4;
            this.BotonEstudios.Text = "Estudios";
            this.BotonEstudios.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(197, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(399, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BotonEstudios);
            this.Controls.Add(this.BotonProductores);
            this.Controls.Add(this.BotonDirectores);
            this.Controls.Add(this.BotonActores);
            this.Controls.Add(this.BotonPeliculas);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.timer1_Tick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonPeliculas;
        private System.Windows.Forms.Button BotonActores;
        private System.Windows.Forms.Button BotonDirectores;
        private System.Windows.Forms.Button BotonProductores;
        private System.Windows.Forms.Button BotonEstudios;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}