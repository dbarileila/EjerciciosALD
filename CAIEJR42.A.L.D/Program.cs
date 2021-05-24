using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIEJR42.A.L.D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de una palabra al usuario y la presente escrita al revés.

            List<string> lstString = new List<string>();

            string ingreso = "";
            bool ok = false;
            while(!ok)
            {
                Console.Write($"Ingrese una palabra para la posición {lstString.Count}: ");
                ingreso = Console.ReadLine();
                ok = string.IsNullOrEmpty(ingreso);

                if(ok)
                {
                    Console.WriteLine("Debe ingresar una palabra.");
                }
                else
                {
                    lstString.Add(ingreso);
                    break;
                }

            }

            lstString.Reverse();
            foreach (string str in lstString)
            {
                Console.WriteLine(str);
            }
            
            Console.ReadLine();


        }
    }
}
