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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Pelicula p in BaseDeDatos.peliculas)
            {
                MessageBox.Show(p.nombre);
            }
        }
    }
}
