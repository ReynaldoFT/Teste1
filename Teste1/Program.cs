using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
     internal class Program
    {
        static void Main(string[] args)
        {
            double a, b = 0, c;

            Console.WriteLine("Digite um numero");
            a = Convert.ToDouble(Console.ReadLine());

            while (b < 10)
            {
                b = b + 1;
                c = a * b;
                Console.WriteLine(a + "*" + b + "=" + c);
            }

            Console.ReadKey();
        }
    }
}
