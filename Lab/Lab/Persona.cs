using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public string fechaDeNacimiento;
        public string biografia;

        public Persona(string nombre, string apellido, string fechaDeNacimiento, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.biografia = biografia;
        }
    }
}
