using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasLab
{
    class DirectoresController
    {
        DirectoresForm directoresForm;

        public DirectoresController(DirectoresForm directoresForm)
        {
            this.directoresForm = directoresForm;
            this.directoresForm.OnRegresar += DirectoresForm_OnRegresar;
        }

        public void DirectoresForm_OnRegresar(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            VentanaPrincipalController ventanaPrincipalController = new VentanaPrincipalController(ventanaPrincipal);
            ventanaPrincipal.Show();
        }
    }
}
