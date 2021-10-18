using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Alumno : Persona
    {
        private string matricula;
        private string carrera;

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }
        public string Carrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }
        public Alumno() : base()
        {
            matricula = "";
            carrera = "";
        }
        public Alumno(string fechaNacimiento, string nombre, string matricula, string carrera) : base (fechaNacimiento, nombre)
        {
            this.matricula = matricula;
            this.carrera = carrera;
        }

        public override string ToString()
        {
            return "nombre:" + Nombre + "\nfechaNacimiento" + FechaNacimiento + "\nmatricula:" + Matricula + "\ncarrera" + Carrera;
        }




    }
}
