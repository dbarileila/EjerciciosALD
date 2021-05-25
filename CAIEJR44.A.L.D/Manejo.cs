using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CAIEJR44.A.L.D
{
    static class Manejo
    {
        private static  List<Nombre> lstNombres;
        public static void Agregar(Nombre nombre)
        {
            lstNombres = new List<Nombre>();
            Console.WriteLine($"El nombre se guardó en la posición {lstNombres.Count}");
            lstNombres.Add(nombre);
            Console.WriteLine("Se ha guardado el nombre en la lista.");
        }

        public static void BajaNum()
        {
            bool ok = false;
            Console.WriteLine();
            Console.Write("Ingrese la posición a borrar: ");
            ok = false;
            int posicionaborrar = -1;
            while (!ok)
            {
                string ingreso = Console.ReadLine();
                ok = int.TryParse(ingreso, out posicionaborrar);
                if (!ok)
                {
                    Console.WriteLine("No ha ingresado un entero válido.");
                }
                else if (posicionaborrar < 0 || posicionaborrar > lstNombres.Count - 1)
                {
                    Console.WriteLine($"La lista sólo tiene {lstNombres.Count} posiciones");
                    ok = false;
                }


            }

            lstNombres.RemoveAt(posicionaborrar);

            Console.WriteLine();
            Console.WriteLine($"Tenemos {lstNombres.Count} elementos");
            for (int indice = 0; indice < lstNombres.Count; indice++)
            {
                Console.WriteLine($"Posición: {indice}: {lstNombres[indice]}");
            }
        }

        public static void Seleccionar(string nombre)
        {
           

           
        }
    }
}