using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a;
            a = new Alumno();

            Console.WriteLine("Fecha de nacimiento :");
            a.FechaNacimiento  = Console.ReadLine();

            Console.WriteLine("Nombre:");
            a.Nombre  = Console.ReadLine();

            Console.WriteLine("Matricula:");
            a.Matricula  = Console.ReadLine();

            Console.WriteLine("Carrera que cursa:");
            a.Carrera = Console.ReadLine();
            Console.WriteLine(a.ToString());

           
         
            Console.ReadKey();
        }
    }
}
