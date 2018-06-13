using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasLab
{
    class PeliculasController
    {
        PeliculasForm peliculasForm;

        public PeliculasController(PeliculasForm peliculasForm)
        {
            this.peliculasForm = peliculasForm;
            this.peliculasForm.OnRegresar += PeliculasForm_OnRegresar;
        }

        public void PeliculasForm_OnRegresar(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            VentanaPrincipalController ventanaPrincipalController = new VentanaPrincipalController(ventanaPrincipal);
            ventanaPrincipal.Show();
        }
    }
}
