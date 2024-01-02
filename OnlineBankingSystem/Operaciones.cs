using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    internal class Operaciones
    {
        public static decimal saldoCuenta = 2000;
        private static string valor;

        public static void Depositar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el valor a depositar");
                valor = Console.ReadLine();
                if (!decimal.TryParse(valor, out var depo))
                {
                    Console.WriteLine("Ingrese un numero válido");
                    continue;
                }

                Console.WriteLine("Ahora tiene " + (saldoCuenta + depo) + " en su cuenta");
                break;
            }
        }

        public static void Extraer()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el valor a extraer");
                valor = Console.ReadLine();
                if (!decimal.TryParse(valor, out var ext))
                {
                    Console.WriteLine("Ingrese un numero válido");
                    continue;
                }
                if (ext > saldoCuenta)
                {
                    Console.WriteLine("No tiene fondos para esta extracción");
                    continue;
                }

                Console.WriteLine("Ahora tiene " + (saldoCuenta - ext) + " en su cuenta");
                break;
            }
        }
        public static void Transferir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el usuario a transferir");
                string usr = Console.ReadLine();
                if(usr  == null)
                {
                    Console.WriteLine("Debe ingresar un usuario");
                    continue;
                }
                if(usr != "User1" || usr != "User2" || usr != "User3")
                {
                    Console.WriteLine("Usuario inexixtente");
                    continue;
                }
                Console.WriteLine("Ingrese el valor a transferir");
                valor = Console.ReadLine();
                if (!decimal.TryParse(valor, out var ext))
                {
                    Console.WriteLine("Ingrese un numero válido");
                    continue;
                }
                if (ext > saldoCuenta)
                {
                    Console.WriteLine("No tiene fondos para esta transferencia");
                    continue;
                }

                Console.WriteLine("Ahora tiene " + (saldoCuenta - ext) + " en su cuenta");
                break;
            }
        }

        public static void consultar()
        {
            Console.WriteLine("Su saldo es: " + saldoCuenta);
        }



    }
    
}
