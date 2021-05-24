using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIEJR41.A.L.D
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solicite el ingreso de una serie de fechas al usuario y las presente ordenadas en forma ascendente.

            List<DateTime> listFechas = new List<DateTime>();

            var salida = new DateTime();
            bool ok = false;
            string ingreso = "";

            do
            {
                ok = false;
                Console.Write($"Ingrese una fecha para la posición {listFechas.Count} o la fecha actual para finalizar: ");
                while (!ok)
                {
                    ingreso = Console.ReadLine();
                    ok = DateTime.TryParse(ingreso, out salida);
                    if (!ok)
                    {
                        Console.WriteLine("No ingreso una fecha válida.");

                    }
                    else if (salida == DateTime.Today)
                    {
                        break;
                    }
                    else
                    {
                        listFechas.Add(salida);
                        break;
                    }

                }
            } while (salida != DateTime.Today);


            listFechas.Sort();

            Console.WriteLine();
            Console.WriteLine("Fechas ordenadas de forma ascendente: ");
            foreach (DateTime dt in listFechas)
            {
                Console.WriteLine($"{dt}");
            }

            Console.ReadKey();
        }


    }
    
}
