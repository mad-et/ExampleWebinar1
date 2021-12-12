using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            while (s.IndexOf('{') > -1 &&  s.IndexOf('}') > -1)
            {
                int i1 = s.IndexOf('{');
                int i2 = s.IndexOf('}');
                if (i1 > -1 && i2 > -1)
                {
                    int count = i2 - i1 + 1;
                    s = s.Remove(i1, count);
                }
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
