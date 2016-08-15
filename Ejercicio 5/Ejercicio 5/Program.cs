using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            
            Console.WriteLine("Introduce tu edad: ");
            edad = int.Parse(Console.ReadLine());

            if(edad>=21)
            Console.WriteLine("Felicidades, usted ya puede votar!!!");
            else
            Console.WriteLine("Lo siento, usted aun no puede votar...");
            Console.ReadLine();


        }
    }
}
