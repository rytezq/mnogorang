using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите размер строк");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите размер столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] ms = new int[m, n];
            Random random = new Random();
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                for (int j = 0; j < ms.GetLength(1); j++)
                {
                    ms[i, j] = random.Next(1, 101);
                    Console.Write(ms[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] sm = new int[n, m];
            for (int i = 0; i < sm.GetLength(0); i++)
            {
                for (int j = 0; j < sm.GetLength(1); j++)
                {
                    sm[i, j] = ms[j, i];
                    Console.Write(sm[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
