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
    public partial class ProductoresForm : Form
    {
        public event EventHandler OnRegresar;

        public ProductoresForm()
        {
            InitializeComponent();
            InicializarListBox();
            
        }

        public void InicializarListBox()
        {
            List<string> nombresProductores = new List<string>();
            foreach (Productor p in BaseDeDatos.productores)
            {
                nombresProductores.Add(p.nombre);
            }  
            listBox1.DataSource = nombresProductores;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaseDeDatos.mostrar)
            { 
                foreach (Productor productor in BaseDeDatos.productores)
                {
                    if (productor.nombre == listBox1.SelectedItem.ToString())
                    {
                        MessageBox.Show($"Nombre: {productor.nombre} {productor.apellido}\n" +
                            $"Fecha de nacimiento: {productor.fechaDeNacimiento}\n" +
                            $"Biografia: {productor.biografia}");
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
