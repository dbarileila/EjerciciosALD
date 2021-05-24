using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIEJR40.A.L.D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de una frase al usuario y presente cada palabra en una línea por separado.

            List<string> listaDeFrases = new List<string>();
            string ingreso = "";
            bool ok = false;

            Console.WriteLine($"Ingrese una frase para la posición {listaDeFrases.Count}.");
            while (!ok)
            {
                ingreso = Console.ReadLine();
                ok = string.IsNullOrEmpty(ingreso);
                if (ok)
                {
                    Console.WriteLine("Debe ingresar una frase.");

                }

                else
                {
                    listaDeFrases.Add(ingreso);
                    break;
                }

            }

            //CREO UN ARRAY PARA GUARDAR EL OBJETO FRASE SEPARADO.
            string[] separar = ingreso.Split(' ');

            Console.WriteLine("La frase por líneas:");
            foreach (var sep in separar)
            {
                Console.WriteLine(sep);
            }

            Console.ReadLine();
        }

    }
    
}
