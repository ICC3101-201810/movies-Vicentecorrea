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
            this.ventanaPrincipal.OnAbrirDirectores += VentanaPrincipal_OnAbrirDirectores;
            this.ventanaPrincipal.OnAbrirProductores += VentanaPrincipal_OnAbrirProductores;
            this.ventanaPrincipal.OnAbrirEstudios += VentanaPrincipal_OnAbrirEstudios;
            this.ventanaPrincipal.OnAbrirBuscar += VentanaPrincipal_OnAbrirBuscar;
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

        private void VentanaPrincipal_OnAbrirDirectores(object sender, EventArgs e)
        {
            DirectoresForm directoresForm = new DirectoresForm();
            DirectoresController directoresController = new DirectoresController(directoresForm);
            BaseDeDatos.mostrar = true;
            directoresForm.Show();
        }

        private void VentanaPrincipal_OnAbrirProductores(object sender, EventArgs e)
        {
            ProductoresForm productoresForm = new ProductoresForm();
            ProductoresController productoresController = new ProductoresController(productoresForm);
            BaseDeDatos.mostrar = true;
            productoresForm.Show();
        }

        private void VentanaPrincipal_OnAbrirEstudios(object sender, EventArgs e)
        {
            EstudiosForm estudiosForm = new EstudiosForm();
            EstudiosController estudiosController = new EstudiosController(estudiosForm);
            BaseDeDatos.mostrar = true;
            estudiosForm.Show();
        }

        private void VentanaPrincipal_OnAbrirBuscar(object sender, EventArgs e)
        {
            BuscarForm buscarForm = new BuscarForm();
            BuscarController buscarController = new BuscarController(buscarForm);
            BaseDeDatos.mostrar = true;
            buscarForm.Show();
        }
    }
}
