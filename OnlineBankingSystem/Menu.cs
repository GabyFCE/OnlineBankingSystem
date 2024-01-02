using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    internal static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("Menu principal");
            Console.WriteLine("1-Depositar");
            Console.WriteLine("2-Extraer");
            Console.WriteLine("3-Transferir");
            Console.WriteLine("4-Consultar Saldo");
            Console.WriteLine("5-Salir");

            while (true)
            {
                Console.WriteLine("ingrese su opción:");
                var ingreso = Console.ReadLine();
                if (!int.TryParse(ingreso, out var opcion))
                {
                    Console.WriteLine("Ingrese un numero válido");
                    continue;
                }

                if (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Ingrese 1-5");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Operaciones.Depositar();
                        break;

                    case 2:
                        Operaciones.Extraer();
                        break;

                    case 3:
                        Operaciones.Transferir();
                        break;

                    case 4:
                        Operaciones.consultar();
                        break;

                    case 5: //finalizar
                        return;


                }

                break;
            }

        }
    }
}
