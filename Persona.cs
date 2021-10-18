using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Persona
    {
        private string fechaNacimiento;
        private string nombre;

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public Persona()
        {
            fechaNacimiento = "";
            nombre = "";
        }

        public Persona(string fechaNacimiento, string nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
        }
        

        public override string ToString()
        {
            return "\nfechaNacimiento: " + FechaNacimiento + "nombre: " + Nombre;

        }
    }
}
