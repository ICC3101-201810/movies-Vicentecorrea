using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace VistasLab
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bienvenida bienvenida = new Bienvenida();
            bienvenida.Show();
            Thread.Sleep(5000);
            bienvenida.Close();

            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            VentanaPrincipalController ventanaPrincipalController = new VentanaPrincipalController(ventanaPrincipal);
            Application.Run(ventanaPrincipal);

        }
    }
}
