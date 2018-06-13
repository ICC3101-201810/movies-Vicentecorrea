using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class BaseDeDatos
    {
        public static Director PeterJackson = new Director("Peter", "Jackson", "31 de octubre de 1961", "Nacio siendo crack");
        public static Director GeorgeLucas = new Director("George", "Lucas", "14 de mayo de 1944", "El primer jedi");
        public static Estudio CenturyFox = new Estudio("Century Fox", "Calle Falsa 123", "23 de agosto de 1994");
        public static Pelicula ESdlA = new Pelicula("El Señor de los Anillos", PeterJackson, "10 de abril de 2002", "muy wena", 200000, CenturyFox);
        public static Pelicula StarWars = new Pelicula("Star Wars", GeorgeLucas, "17 de enero de 1986", "un clasico de los clasicos", 85000, CenturyFox);

        public static List<Pelicula> peliculas = new List<Pelicula> { ESdlA, StarWars };
        public static List<Persona> personas = new List<Persona> { PeterJackson, GeorgeLucas };
        public static List<Estudio> estudios = new List<Estudio> { CenturyFox };

        public static bool mostrar = false;
    }

}

