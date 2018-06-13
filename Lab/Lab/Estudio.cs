using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Estudio
    {
        public string nombre;
        public string direccion;
        public string fechaDeApertura;

        public Estudio(string n, string d, string fda)
        {
            this.nombre = n;
            this.direccion = d;
            this.fechaDeApertura = fda;
        }
    }
}
