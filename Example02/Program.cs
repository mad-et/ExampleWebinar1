using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s0 = Console.ReadLine();
            int ind = 0;
            bool f = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s0[ind])
                {
                    ind = 0;
                }

                if (s[i] == s0[ind])
                {
                    ind++;
                    if (ind == s0.Length)
                    {
                        //Console.WriteLine("Найдена");
                        f = true;
                        //Console.ReadKey();
                        //return;
                        break;
                    }
                }
            }

            if (f)
            {
                Console.WriteLine("Найдена");
            }
            else
            {
                Console.WriteLine("Не найдено");
            }
            Console.ReadKey();
        }
    }
}
