using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создайте квадратный массив");
            int a = Convert.ToInt32(Console.ReadLine());
            int[,] ms = new int[a, a];
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
        }
    }
}
