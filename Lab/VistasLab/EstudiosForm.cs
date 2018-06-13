using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab;

namespace VistasLab
{
    public partial class EstudiosForm : Form
    {
        public event EventHandler OnRegresar;

        public EstudiosForm()
        {
            InitializeComponent();
            InicializarListBox();
            
        }

        public void InicializarListBox()
        {
            List<string> nombresEstudios = new List<string>();
            foreach (Estudio e in BaseDeDatos.estudios)
            {
                nombresEstudios.Add(e.nombre);
            }  
            listBox1.DataSource = nombresEstudios;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaseDeDatos.mostrar)
            { 
                foreach (Estudio estudio in BaseDeDatos.estudios)
                {
                    if (estudio.nombre == listBox1.SelectedItem.ToString())
                    {
                        MessageBox.Show($"Nombre: {estudio.nombre}\n" +
                            $"Direccion: {estudio.direccion}\n" +
                            $"Fecha de apertura: {estudio.fechaDeApertura}");
                    }   
                }
            }
        }



        private void PeliculasForm_Load(object sender, EventArgs e)
        {
            
        }

        private void PeliculasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            BaseDeDatos.mostrar = false;
            OnRegresar(this, EventArgs.Empty);
            this.Hide();        
        }
    }
}
