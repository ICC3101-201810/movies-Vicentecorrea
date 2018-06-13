using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasLab
{
    class ActoresController
    {
        ActoresForm actoresForm;

        public ActoresController(ActoresForm actoresForm)
        {
            this.actoresForm = actoresForm;
            this.actoresForm.OnRegresar += ActoresForm_OnRegresar;
        }

        public void ActoresForm_OnRegresar(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            VentanaPrincipalController ventanaPrincipalController = new VentanaPrincipalController(ventanaPrincipal);
            ventanaPrincipal.Show();
        }
    }
}
