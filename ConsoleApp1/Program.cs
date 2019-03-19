using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 clase1 = new Class1();
            Class2 clase2 = new Class2();
            String propiedad = clase1._p1;
            String propiedad2 = clase2._p1;

            Console.WriteLine(propiedad);
            Console.WriteLine(propiedad2);
            clase1.M1();
            clase2.M1();

            Console.WriteLine(Environment.NewLine);

            Email email = new Email();

            email.ComprobarEmail();        // Se genera advertencia en tiempo de compilación: CS0612
            email.ValidarEmail();        // No genera ninguna advertencia o error en tiempo de compilación.

            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }
    }
}
