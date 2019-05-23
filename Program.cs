using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var left = 3 * n;
            var middle = 0;
            var right = 5 * n - left - middle - 2;
            for (int i = 0; i < n; i++)
            { Console.WriteLine("{0}*{1}*{2}",
                new string('-', left),
                new string('-', middle),
                new string('-', right));
                middle++;
                right--;
            }
            
            for (int p = 0; p < n / 2; p++)
            { Console.WriteLine("{0}*{1}*{2}",
                new string('*', left),
                new string('-', middle),
                new string('-', right)); }
            for (var b = 0; b < n/2-1; b++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', left),
                    new string('-', middle),
                    new string('-', right));
                left--;
                middle+=2;
                right--;
            }
            Console.WriteLine("{0}*{1}*{ 2}", new string('-', left), new string('*', middle), new string('-', right));

        }
    }
}
