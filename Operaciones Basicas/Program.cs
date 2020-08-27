using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operaciones_Basicas
{
    class Program
    {
        static Operaciones opera = new Operaciones();
        static Menu m = new Menu();

        static void Main(string[] args)
        {
            int opciones = 0;

            while (opciones != 6)
            {
                opciones = m.ListaMenu();

                if (opciones == 1)
                {
                    Console.WriteLine(opera.Resultado('s'));
                }

                else if (opciones == 2)
                {
                    Console.WriteLine(opera.Resultado('r'));
                }

                else if (opciones == 3)
                {
                    Console.WriteLine(opera.Resultado('m'));
                }

                else if (opciones == 4)
                {
                    Console.WriteLine(opera.Resultado('d'));
                }

                else if (opciones == 5)
                {
                    Console.WriteLine(opera.Resultado('p'));
                }
            }

            Console.ReadKey();

        }
    }
}
    

