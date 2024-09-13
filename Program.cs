using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 3;
            double result;
            result = (Math.Pow(a + b, 3) - (Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b)) / (3 * a * Math.Pow(b, 2) + Math.Pow(b, 3));
            Console.WriteLine("result = {0}", result);
            Console.ReadKey();
        }
    }
}
