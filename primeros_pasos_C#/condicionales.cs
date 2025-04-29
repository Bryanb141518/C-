using System;
using System.ComponentModel.Design;

namespace CondicionalIF
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {


                if (numero > 0) Console.WriteLine("el numero es positivo");

                else if (numero < 0) Console.WriteLine("el numero es negativo");

                else  Console.WriteLine("el numero es cero");

            }
            else
            {
                Console.WriteLine("entrada invalida ingrese un numero entero");
            }
        }
    }

}