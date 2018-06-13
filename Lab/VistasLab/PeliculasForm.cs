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
        public PeliculasForm()
        {
            InitializeComponent();
            //InicializarLista();
            List<string> nombresPeliculas = new List<string>();
            foreach (Pelicula p in BaseDeDatos.peliculas)
            {
                nombresPeliculas.Add(p.nombre);
            }
            this.listBox1.DataSource = nombresPeliculas;
        }
        /*
        public void InicializarLista()
        {
            List<string> nombresPeliculas = new List<string>();
            foreach (Pelicula p in BaseDeDatos.peliculas)
            {
                nombresPeliculas.Add(p.nombre);
            }
            listBox1.DataSource = nombresPeliculas;
        }
        */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PeliculasForm_Load(object sender, EventArgs e)
        {

        }

        private void PeliculasForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
