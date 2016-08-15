using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Ingresa Una Altura En cm.");
            size = int.Parse(Console.ReadLine());

            if (size >= 180)
            {
                Console.WriteLine("La persona es de altura muy alta.");
            }
            else
            {
                if (size < 179 && size >= 170)
                {
                    Console.WriteLine("La persona es de altura alta.");
                }
                else
                {
                    if (size < 169 && size >= 160)
                    {
                        Console.WriteLine("La persona es de altura media.");
                    }
                    else
                    {
                        if (size < 159 && size >= 150)
                        {
                            Console.WriteLine("La persona es de altura baja.");
                        }
                        else
                        {
                            Console.Write("La persona es de altura muy baja.");
                        }
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
