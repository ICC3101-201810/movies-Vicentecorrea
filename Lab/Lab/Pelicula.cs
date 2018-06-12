using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Pelicula
    {
        string nombre;
        Director director;
        string fechaDeEstreno;
        string descripcion;
        double presupuesto;
        Estudio estudio;

        public Pelicula(string n, Director director, string fde, string des, double p, Estudio estudio)
        {
            this.nombre = n;
            this.director = director;
            this.fechaDeEstreno = fde;
            this.descripcion = des;
            this.presupuesto = p;
            this.estudio = estudio;
        }
    }
}
