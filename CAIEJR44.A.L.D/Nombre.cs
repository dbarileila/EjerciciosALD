using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIEJR44.A.L.D
{
    internal class Nombre
    {

        public string cadenaNombre { get; set; }

        public Nombre()
        {

        }
        public static Nombre IngresarNuevo()
        {
            var nombre = new Nombre();

            Console.WriteLine("Nuevo nombre: ");

            nombre.cadenaNombre = IngresarNombre();

            return nombre;
        }

        private static string IngresarNombre()
        {
            string ingreso;
            do
            {
                ingreso = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("No ingreso un nombre.");
                    continue;
                }

                if (ingreso.Any(Char.IsDigit))
                {
                    Console.WriteLine("El nombre no puede contener números.");
                    continue;
                }


                break;



            } while (true);

            return ingreso;
        }
    }
}