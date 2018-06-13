using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasLab
{
    class EstudiosController
    {
        EstudiosForm estudiosForm;

        public EstudiosController(EstudiosForm estudiosForm)
        {
            this.estudiosForm = estudiosForm;
            this.estudiosForm.OnRegresar += EstudiosForm_OnRegresar;
        }

        public void EstudiosForm_OnRegresar(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            VentanaPrincipalController ventanaPrincipalController = new VentanaPrincipalController(ventanaPrincipal);
            ventanaPrincipal.Show();
        }
    }
}
