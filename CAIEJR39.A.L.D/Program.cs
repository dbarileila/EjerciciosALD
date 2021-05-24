using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIEJR39.A.L.D
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solicite el ingreso de una serie de números al usuario y los presente en orden inverso.

            int[] arraynumerosIngreso;

            arraynumerosIngreso = new int[10];

            for (int indice = 0; indice < arraynumerosIngreso.Length; indice++)
            {
                Console.Write($"Ingrese un número para la posición {indice}: ");
                bool ok = false;

                while (!ok)
                {
                    string ingreso = Console.ReadLine();
                    ok = int.TryParse(ingreso, out arraynumerosIngreso[indice]);

                    if (!ok)
                    {
                        Console.WriteLine("No ingreso un número válido.");
                    }

                }
            }

            Console.WriteLine();
            Console.WriteLine("Ingreso de forma inversa: ");
            System.Array.Reverse(arraynumerosIngreso);
            foreach (int valor in arraynumerosIngreso)
            {
                Console.WriteLine(valor);
            }

            Console.ReadKey();



        }
    
    }
}
