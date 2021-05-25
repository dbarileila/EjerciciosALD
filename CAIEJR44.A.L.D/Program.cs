using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIEJR44.A.L.D
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar una aplicación que mantenga una lista de nombres. La aplicación debe interpretar los siguientes
             * “comandos”, que el usuario ingresará hasta finalizar. Si el usuario ingresa:
             * 
               A.   “alta [nombre]”, se insertará la cadena a la lista (ej.: “alta Pedro”).

               B.   “baja [número entero]”, se eliminará la cadena en la posición indicada por el número ingresado. 
                    Debe presentar un mensaje de error si el número está fuera del rango de la lista.

               C.   “baja [nombre]”, se eliminará la cadena de la lista. Debe presentar un mensaje de error si la 
                    cadena no existe.   

               D.   “mostrar”, mostrará las entradas de la lista, una por línea.

               E.   “fin”, finalizará el programa.

               F.   Cualquier otro ingreso indicará “comando inválido” y continuará.
             
             */


            bool salir = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine(@"MENÚ PRINCIPAL.");
                Console.WriteLine("----------------");

                Console.WriteLine("a- Alta");
                Console.WriteLine("b- Baja (número)");
                Console.WriteLine("c- Baja (nombre)");
                Console.WriteLine("d- Mostrar");
                Console.WriteLine("z- Fin");
                Console.WriteLine();

                Console.WriteLine("Ingrese una opción o [ENTER] para salir");
                Console.Write("Opción: ");

                var tecla = Console.ReadLine();

                switch (tecla)
                {
                    case "a":
                        Alta();
                        break;
                    case "b":
                        BajaNumero();
                        break;
                    case "c":
                        BajaNombre();
                        break;
                    case "d":
                        Mostrar();
                        break;
                    case "z":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("No ha ingresado una opción válida.");
                        break;
                }


            } while (!salir);




        }

        private static void Mostrar()
        {
        }

        private static void BajaNombre()
        {
            throw new NotImplementedException();
        }

        private static void BajaNumero()
        {
            Manejo.BajaNum();
        }

        private static void Alta()
        {

            var nombre = Nombre.IngresarNuevo();

            Manejo.Agregar(nombre);

        }
    }
}
