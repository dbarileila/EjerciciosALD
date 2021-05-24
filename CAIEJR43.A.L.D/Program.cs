using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIEJR43.A.L.D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de una serie de números hasta que el usuario ingrese -1. 
            //Luego presentar: el máximo, el mínimo, el promedio, la suma. Realizar todos los cálculos una vez 
            //finalizado el ingreso.

            List<int> lstEnteros = new List<int>();

            bool ok = false;
            int salida = 0;
            do
            {
                ok = false;
                Console.Write($"Ingrese un número para la posición {lstEnteros.Count} o -1 para salir: ");
                
                while(!ok)
                {
                    string ingreso = Console.ReadLine();
                    ok = int.TryParse(ingreso, out salida);

                    if (!ok)
                    {
                        Console.WriteLine("No ingreso un número válido.");
                    }
                    else if (salida == -1)
                    {
                        break;
                    }
                    else
                    {
                        lstEnteros.Add(salida);
                        break;
                    }
                }



            } while (salida != -1);


            Console.WriteLine("Resultados: ");
            var max = lstEnteros.Max();
            var min = lstEnteros.Min();
            var promedio = lstEnteros.Average();
            var suma = lstEnteros.Sum();

            Console.WriteLine($"Máximo: {max} | Mínimo: {min} | Promedio: {promedio} | Suma: {suma}");

            Console.ReadLine();



        }
    }
}
