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
    public partial class PeliculasForm : Form
    {
        public event EventHandler OnRegresar;

        public PeliculasForm()
        {
            InitializeComponent();
            InicializarListBox();
            
        }

        public void InicializarListBox()
        {
            List<string> nombresPeliculas = new List<string>();
            foreach (Pelicula p in BaseDeDatos.peliculas)
            {
                nombresPeliculas.Add(p.nombre);
            }  
            listBox1.DataSource = nombresPeliculas;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaseDeDatos.mostrar)
            { 
                foreach (Pelicula pelicula in BaseDeDatos.peliculas)
                {
                    if (pelicula.nombre == listBox1.SelectedItem.ToString())
                    {
                        MessageBox.Show($"Nombre: {pelicula.nombre}\n" +
                            $"Director: {pelicula.director.nombre} {pelicula.director.apellido}\n" +
                            $"Fecha de estreno: {pelicula.fechaDeEstreno}\n" +
                            $"Descripcion: {pelicula.descripcion}\n" +
                            $"Presupuesto: {pelicula.presupuesto}\n" +
                            $"Estudio: {pelicula.estudio.nombre}");
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
