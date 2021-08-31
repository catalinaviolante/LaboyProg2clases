using System;
using Biblioteca;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo";
            Cuenta c1 = new Cuenta("Catalina Violante", 2000);

            Console.WriteLine(c1.GetTitular());
            Console.WriteLine(c1.GetCantidad());

            Console.ReadKey();

        }
    }
}
