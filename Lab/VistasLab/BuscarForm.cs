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
    public partial class BuscarForm : Form
    {
        public event EventHandler OnRegresar;

        public BuscarForm()
        {
            InitializeComponent();
            InicializarListBox();
            
        }

        public void InicializarListBox()
        {
            List<string> todos = new List<string>();
            foreach (Object t in BaseDeDatos.todos)
            {
                if (t is Pelicula)
                {
                    Pelicula t2 = (Pelicula)t;
                    if ((t2.nombre == BaseDeDatos.buscado) || (t2.descripcion.Contains(BaseDeDatos.buscado)) || (t2.nombre.Contains(BaseDeDatos.buscado)))
                    {
                        todos.Add(t2.nombre);
                    }
                    
                }
                if (t is Persona)
                {
                    Persona t2 = (Persona)t;
                    if ((t2.nombre == BaseDeDatos.buscado) || (t2.apellido == BaseDeDatos.buscado))
                    {
                        todos.Add(t2.nombre + " " + t2.apellido);
                    }
                        
                }
                if (t is Estudio)
                {
                    Estudio t2 = (Estudio)t;
                    if ((t2.nombre == BaseDeDatos.buscado) || (t2.direccion.Contains(BaseDeDatos.buscado)) || (t2.nombre.Contains(BaseDeDatos.buscado)))
                    {
                        todos.Add(t2.nombre);
                    }
                        
                }
            }
            listBox1.DataSource = todos;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaseDeDatos.mostrar)
            {
                foreach (Object todo in BaseDeDatos.todos)
                {
                    
                    if (todo is Pelicula)
                    {
                        Pelicula todo2 = (Pelicula)todo;
                        if (todo2.nombre == listBox1.SelectedItem.ToString())
                        {
                            MessageBox.Show($"Nombre: {todo2.nombre}\n" +
                            $"Director: {todo2.director.nombre} {todo2.director.apellido}\n" +
                            $"Fecha de estreno: {todo2.fechaDeEstreno}\n" +
                            $"Descripcion: {todo2.descripcion}\n" +
                            $"Presupuesto: {todo2.presupuesto}\n" +
                            $"Estudio: {todo2.estudio.nombre}");
                        }
                    }
                    if (todo is Estudio)
                    {
                        Estudio estudio = (Estudio)todo;
                        if (estudio.nombre == listBox1.SelectedItem.ToString())
                        {
                            MessageBox.Show($"Nombre: {estudio.nombre}\n" +
                                $"Direccion: {estudio.direccion}\n" +
                                $"Fecha de apertura: {estudio.fechaDeApertura}");
                        }
                    }
                    if (todo is Persona)
                    {
                        Persona persona = (Persona)todo;
                        if ((persona.nombre + " " + persona.apellido) == listBox1.SelectedItem.ToString())
                        {
                            MessageBox.Show($"Nombre: {persona.nombre} {persona.apellido}\n" +
                            $"Fecha de nacimiento: {persona.fechaDeNacimiento}\n" +
                            $"Biografia: {persona.biografia}");
                        }
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
