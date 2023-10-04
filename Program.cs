using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob01_Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            double resultado = 0;
            for (int i = 1; i <= n; i++)
            {
                resultado = 1.0 / i;
                Console.WriteLine($"resultado : {resultado:F7}");
            }

            resultado = 0;
            for (int i = 1; i <= n; i++)
            {
                resultado += 1.0 / i;
            }

            Console.WriteLine(resultado);
        }
    }

}
    
