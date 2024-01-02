using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBankingSystem
{
    internal static class Login
    {
        public static void Auth()
        {
            String usuario;
            String password;
            int cont = 0;

            
            Console.WriteLine("Existen tres usuarios, User1, User2 y User3.  El password es igual al nombre de usuario");
            Console.WriteLine("\n" + "\n" + "\n");
      
            while (cont < 3)
            {
                Console.WriteLine("Ingrese nombre de usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese password");
                password = Console.ReadLine();
                if (usuario == "User1" && password == "User1" || usuario == "User2" && password == "User2" || usuario == "User3" && password == "User3")
            {
                    Menu.Mostrar();
                    break;
            }
                else
            {
                    Console.Clear();
                    Console.WriteLine("Usuario y Password incorrectos.");
                    cont++;

            }
            }
        }
    }
}
