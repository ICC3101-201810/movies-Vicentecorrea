using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Estudio
    {
        string nombre;
        string direccion;
        string fechaDeApertura;

        public Estudio(string n, string d, string fda)
        {
            this.nombre = n;
            this.direccion = d;
            this.fechaDeApertura = fda;
        }
    }
}
