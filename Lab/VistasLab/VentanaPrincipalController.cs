using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab;

namespace VistasLab
{
    class VentanaPrincipalController
    {
        VentanaPrincipal ventanaPrincipal;

        public VentanaPrincipalController(VentanaPrincipal ventanaPrincipal)
        {
            this.ventanaPrincipal = ventanaPrincipal;
            this.ventanaPrincipal.OnAbrirPeliculas += VentanaPrincipal_OnAbrirPeliculas; 
        }

        private void VentanaPrincipal_OnAbrirPeliculas(object sender, EventArgs e)
        {
            
            PeliculasForm peliculasForm = new PeliculasForm();
            PeliculasController peliculasController = new PeliculasController(peliculasForm);
            BaseDeDatos.mostrar = true;
            peliculasForm.Show();
        }
    }
}
