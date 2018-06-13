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
            this.ventanaPrincipal.OnAbrirActores += VentanaPrincipal_OnAbrirActores;
        }

        private void VentanaPrincipal_OnAbrirPeliculas(object sender, EventArgs e)
        {
            
            PeliculasForm peliculasForm = new PeliculasForm();
            PeliculasController peliculasController = new PeliculasController(peliculasForm);
            BaseDeDatos.mostrar = true;
            peliculasForm.Show();
        }

        private void VentanaPrincipal_OnAbrirActores(object sender, EventArgs e)
        {
            ActoresForm actoresForm = new ActoresForm();
            ActoresController actoresController = new ActoresController(actoresForm);
            BaseDeDatos.mostrar = true;
            actoresForm.Show();
        }
    }
}
