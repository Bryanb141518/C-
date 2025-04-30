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


                if (numero > 0 && numero % 2 == 0) Console.WriteLine("el numero es positivo y par");

                else if (numero > 0 && numero % 2 == 1) Console.WriteLine("el numero es positivo e impar");

                else if (numero < 0 && numero % 2 == 0) Console.WriteLine("el numero es negativo y par");


                else if (numero < 0 && numero % 2  != 0 ) Console.WriteLine("el numero es negativo e impar");

                else Console.WriteLine("el numero es cero");

                

            }
            else
            {
                Console.WriteLine("entrada invalida ingrese un numero ");
            }
        }
    }

    class practicas
    {
        private static void main(string[] args)
        {
            
            Console.WriteLine("ingrese un nuemro del 1 al 7");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("lunes");
                        break;
                    case 2:
                        Console.WriteLine("martes");
                        break;
                    case 3:
                        Console.WriteLine("miercoles");
                        break;
                    case 4:
                        Console.WriteLine("jueves");
                        break;
                    case 5:
                        Console.WriteLine("viernes");
                        break;
                    case 6:
                        Console.WriteLine("sabado");
                        break;
                    case 7:
                        Console.WriteLine("domindgo");
                        break;
                    default:
                        Console.WriteLine("dia invalido");
                        break;
                }
            }
        }
    }
}
