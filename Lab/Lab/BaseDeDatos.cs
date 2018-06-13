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
        public static Estudio ColumbiaPictures = new Estudio("Columbia Pictures", "Colombia 973", "7 de enero de 1834");
        public static Pelicula ESdlA = new Pelicula("El Señor de los Anillos", PeterJackson, "10 de abril de 2002", "muy wena", 200000, CenturyFox);
        public static Pelicula StarWars = new Pelicula("Star Wars", GeorgeLucas, "17 de enero de 1986", "un clasico de los clasicos", 85000, ColumbiaPictures);
        public static Actor WillSmith = new Actor("Will", "Smith", "12 de octubre de 1983", "El papa de karate kid");
        public static Actor CeciliaBolocco = new Actor("Cecilia", "Bolocco", "1 de abril de 1780", "La miss universo chilena, orgullo de la nacion");
        public static Productor StevenSpielBerg = new Productor("Steven", "Spielberg", "29 de febrero de 1956", "es viejo");
        public static Productor AngelinaJolie = new Productor("Angelina", "Jolie", "31 de diciembre de 1983", "ella");

        public static List<Pelicula> peliculas = new List<Pelicula> { ESdlA, StarWars };
        public static List<Persona> personas = new List<Persona> { PeterJackson, GeorgeLucas, WillSmith, StevenSpielBerg, CeciliaBolocco, AngelinaJolie };
        public static List<Estudio> estudios = new List<Estudio> { CenturyFox, ColumbiaPictures };
        public static List<Actor> actores = new List<Actor> { WillSmith, CeciliaBolocco };
        public static List<Productor> productores = new List<Productor> { StevenSpielBerg, AngelinaJolie };
        public static List<Director> directores = new List<Director> { PeterJackson, GeorgeLucas };

        public static bool mostrar = false;
    }

}

