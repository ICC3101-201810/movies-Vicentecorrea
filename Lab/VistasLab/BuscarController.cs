using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasLab
{
    class BuscarController
    {
        BuscarForm buscarForm;

        public BuscarController(BuscarForm buscarForm)
        {
            this.buscarForm = buscarForm;
            this.buscarForm.OnRegresar += BuscarForm_OnRegresar;
        }

        public void BuscarForm_OnRegresar(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            VentanaPrincipalController ventanaPrincipalController = new VentanaPrincipalController(ventanaPrincipal);
            ventanaPrincipal.Show();
        }
    }
}
