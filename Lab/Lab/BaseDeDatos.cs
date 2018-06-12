using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class BaseDeDatos
    {
        List<Pelicula> peliculas;
        List<Persona> personas;
        List<Estudio> estudios;
        
        public BaseDeDatos(List<Pelicula> pelicula, List<Persona> persona, List<Estudio> estudio)
        {
            this.peliculas = pelicula;
            this.personas = persona;
            this.estudios = estudio;
        }
    }
}
