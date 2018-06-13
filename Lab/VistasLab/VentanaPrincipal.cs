using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Lab;

namespace VistasLab
{
    public partial class VentanaPrincipal : Form
    {
        public event EventHandler OnAbrirPeliculas;
        public event EventHandler OnAbrirActores;
        public event EventHandler OnAbrirDirectores;
        public event EventHandler OnAbrirProductores;
        public event EventHandler OnAbrirEstudios;
        public event EventHandler OnAbrirBuscar;

        public VentanaPrincipal()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        public void InicializarComboBox()
        {
            
        }

        private void BotonPeliculas_Click(object sender, EventArgs e)
        {
            BaseDeDatos.mostrar = false;
            OnAbrirPeliculas(this, EventArgs.Empty);
            this.Hide();
        }

        private void BotonPeliculas_MouseClick(object sender, MouseEventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BotonActores_Click(object sender, EventArgs e)
        {
            BaseDeDatos.mostrar = false;
            OnAbrirActores(this, EventArgs.Empty);
            this.Hide();
        }

        private void VentanaPrincipal_FormLoad(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BotonDirectores_Click(object sender, EventArgs e)
        {
            BaseDeDatos.mostrar = false;
            OnAbrirDirectores(this, EventArgs.Empty);
            this.Hide();
        }

        private void BotonProductores_Click(object sender, EventArgs e)
        {
            BaseDeDatos.mostrar = false;
            OnAbrirProductores(this, EventArgs.Empty);
            this.Hide();
        }

        private void BotonEstudios_Click(object sender, EventArgs e)
        {
            BaseDeDatos.mostrar = false;
            OnAbrirEstudios(this, EventArgs.Empty);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                BaseDeDatos.buscado = textBox1.Text;
                BaseDeDatos.mostrar = false;
                OnAbrirBuscar(this, EventArgs.Empty);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debes ingresar minimos 3 caracteres", "Error de busqueda");
            }
            
        }
    }
}
