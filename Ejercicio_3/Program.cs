using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    /*
    03.  Mostrar por pantalla todos los números primos que haya hasta el 
    número que ingrese el usuario por consola.  
 
    Nota: Utilizar estructuras repetitivas, selectivas y la función 
    módulo (%).
    */

    class Ejericicio_3
    {
        static void Main(string[] args)
        {
            int num;
            int i;

            Console.Title = "Ejercicio Nro. 3";

            Console.Write("Ingrese un numero mayor a 0: ");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.Clear();
                    Console.Write("ERROR!!! no se ha ingresado un numero. Ingrese un numero mayor a 0: ");
                }

                if (num <= 0)
                {
                    Console.Clear();
                    Console.Write("ERROR!!! Ingrese un numero mayor a 0: ");
                }
            } while (num <= 0);

            Console.Clear();
            Console.WriteLine("Mostrando numeros primos que hay hasta el {0}: ", num);

            for (int j = 2; j <= num; j++)
            {
                for (i = 2; i < j; i++)
                    if (j % i == 0)
                        break;

                if (i == j)
                    Console.WriteLine("{0}", i);
            }

            Console.ReadKey();
        }
    }
}
