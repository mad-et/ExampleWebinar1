using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n/2; i++)
            {
                int t = a[i];
                a[i] = a[n - 1 - i];
                a[n - 1 - i] = t;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.ReadKey();

        }
    }
}
