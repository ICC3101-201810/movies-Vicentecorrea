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
    public partial class DirectoresForm : Form
    {
        public event EventHandler OnRegresar;

        public DirectoresForm()
        {
            InitializeComponent();
            InicializarListBox();
            
        }

        public void InicializarListBox()
        {
            List<string> nombresDirectores = new List<string>();
            foreach (Director d in BaseDeDatos.directores)
            {
                nombresDirectores.Add(d.nombre + " " + d.apellido);
            }  
            listBox1.DataSource = nombresDirectores;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaseDeDatos.mostrar)
            { 
                foreach (Director director in BaseDeDatos.directores)
                {
                    if ((director.nombre + " " + director.apellido) == listBox1.SelectedItem.ToString())
                    {
                        MessageBox.Show($"Nombre: {director.nombre} {director.apellido}\n" +
                            $"Fecha de nacimiento: {director.fechaDeNacimiento}\n" +
                            $"Biografia: {director.biografia}");
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
