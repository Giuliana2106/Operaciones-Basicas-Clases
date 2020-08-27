using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operaciones_Basicas
{
    class Menu
    {
        private int op = 0;

        public int ListaMenu()
        {
            Console.WriteLine("1.-suma");
            Console.WriteLine("2.-resta");
            Console.WriteLine("3.-multi´plicación");
            Console.WriteLine("4.-división");
            Console.WriteLine("5.-potencia");
            Console.WriteLine("6.-salir");
            Console.WriteLine("opción: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
