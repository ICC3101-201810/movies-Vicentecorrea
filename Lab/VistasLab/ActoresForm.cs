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
    public partial class ActoresForm : Form
    {
        public event EventHandler OnRegresar;

        public ActoresForm()
        {
            InitializeComponent();
            InicializarListBox();
            
        }

        public void InicializarListBox()
        {
            List<string> nombresActores = new List<string>();
            foreach (Actor a in BaseDeDatos.actores)
            {
                nombresActores.Add(a.nombre);
            }  
            listBox1.DataSource = nombresActores;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaseDeDatos.mostrar)
            { 
                foreach (Actor actor in BaseDeDatos.actores)
                {
                    if (actor.nombre == listBox1.SelectedItem.ToString())
                    {
                        MessageBox.Show($"Nombre: {actor.nombre} {actor.apellido}\n" +
                            $"Fecha de nacimiento: {actor.fechaDeNacimiento}\n" +
                            $"Biografia: {actor.biografia}");
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
