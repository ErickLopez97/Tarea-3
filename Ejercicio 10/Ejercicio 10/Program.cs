using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {        
            string c;
            Console.Write("Escribe una letra: ");
            c = Console.ReadLine();

            if (c=="a"||c=="e"||c=="i"||c=="o"||c=="u"||c=="A"||c=="E"||c=="I"||c=="O"||c=="U")
            Console.WriteLine("La letra escrita es una vocal.");
            else       
            Console.WriteLine("La letra escrita es una consonant.");

            Console.ReadLine();
        }
    }
}
