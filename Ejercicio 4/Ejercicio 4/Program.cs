using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("Introduce un año:");
            año = int.Parse(Console.ReadLine());

            if (año % 400 == 0)
                Console.WriteLine("El año es Biciesto");
            else
                if (año % 4 == 0 && año % 100 != 0)
                    Console.WriteLine("El año " +año+ " es Biciesto");
                else
                    Console.WriteLine("El año "+año+ " no es Biciesto");
            Console.ReadLine();
        }
    }
}
