using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operaciones_Basicas
{
    class Operaciones
    {
        public OpBasicas opera = new OpBasicas();
        public double n=0;

        public string Resultado(char t)
        {
            double total = 0;

            char op = 's';

            while (op != 'n')
            {
                if (t == 's')
                {
                    total = opera.Suma(total, Pedir());
                }

                else if (t == 'r')
                {
                    total = opera.Resta(total, Pedir());
                }

                else if (t == 'm')
                {
                    total = opera.Multiplicación(total, Pedir());
                }

                else if (t == 'd')
                {
                    total = opera.División(total, Pedir());
                }

                else if (t == 'p')
                {
                    total = opera.Potencia(total, Pedir());
                }

                Console.Write("Desea agregar otro valor [s/n]");
                op = char.Parse(Console.ReadLine());
            }

            return ("el resultado es: " + total);
        }

        private double Pedir()

        {

            double valor = 0;

            bool estado = false;



            while (estado == false)

            {

                Console.Write("ingrese un valor: ");

                try

                {

                    valor = double.Parse(Console.ReadLine());

                    estado = true;

                }

                catch

                {

                    Console.WriteLine("ingrese valores numericos...");

                }

            }


            return valor;
        }
    }
}

