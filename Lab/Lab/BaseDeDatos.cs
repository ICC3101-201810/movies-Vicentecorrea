using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class BaseDeDatos
    {
        Pelicula pelicula;
        Persona persona;
        Estudio estudio;
        
        public BaseDeDatos(Pelicula pelicula, Persona persona, Estudio estudio)
        {
            this.pelicula = pelicula;
            this.persona = persona;
            this.estudio = estudio;
        }
    }
}
