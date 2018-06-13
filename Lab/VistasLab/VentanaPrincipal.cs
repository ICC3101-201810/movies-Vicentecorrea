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
            OnAbrirPeliculas(this, EventArgs.Empty);
            this.Hide();
        }

        private void BotonPeliculas_MouseClick(object sender, MouseEventArgs e){}

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.Show();
            Thread.Sleep(1000); // cambiar a 5000
            bienvenida.Close();
            

        }
    }
}
