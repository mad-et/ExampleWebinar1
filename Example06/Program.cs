using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Еще один способ решения задачи 8.1 на вывод содержимого каталога.
Способ предложил Евгений Миненко.
Используются перегруженные версии методов 
public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
и
public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
Эти версии методов чаще используются для поиска. 
Первый аргумент - это адрес каталога, 
второй - шаблон поиска, 
третий - опции поиска (искать только в текущем каталоге или и во вложенных).
Из достоинств - легко. 
Из недостатков - не получится вывести "иерарархию" содержимого, только список всех файлов отдельно, всех папок - отдельно.
 */
namespace Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp";
            string[] dirs = Directory.GetDirectories(path, "*",SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(path, "*",SearchOption.AllDirectories);


            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            foreach (string s in dirs)
            {
                Console.WriteLine(s);

            }


            Console.ReadKey();
        }
    }
}
