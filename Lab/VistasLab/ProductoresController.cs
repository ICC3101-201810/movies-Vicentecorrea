using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasLab
{
    class ProductoresController
    {
        ProductoresForm productoresForm;

        public ProductoresController(ProductoresForm productoresForm)
        {
            this.productoresForm = productoresForm;
            this.productoresForm.OnRegresar += ProductoresForm_OnRegresar;
        }

        public void ProductoresForm_OnRegresar(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            VentanaPrincipalController ventanaPrincipalController = new VentanaPrincipalController(ventanaPrincipal);
            ventanaPrincipal.Show();
        }
    }
}
