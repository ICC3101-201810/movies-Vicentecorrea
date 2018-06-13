using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Pelicula
    {
        public string nombre;
        public Director director;
        public string fechaDeEstreno;
        public string descripcion;
        public double presupuesto;
        public Estudio estudio;

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
