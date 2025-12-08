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
            int str = 0;
            int stl = 0;
            Console.WriteLine($"Введите количество строк");
            str = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество столбцов");
            stl = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[,] massiv = new int[str, stl];
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stl; j++)
                {
                    massiv[i, j] = random.Next(1, 101);
                    Console.Write(massiv[i, j] + " ");
                }
                Console.WriteLine();
            }
            int lol = 0;
            for (int i = 0; i < str; i++)
            {
                int min = massiv[i, 0];
                int mini = 0;
                for (int j = 0; j < stl; j++)
                {
                    if (massiv[i, j] < min)
                    {
                        min = massiv[i, j];
                        mini = j;
                    }
                }
                int max = massiv[0, mini];
                int maxi = 0;
                for (int k = 0; k < str; k++)
                {
                    if (massiv[k, mini] > max)
                    {
                        max = massiv[k, mini];
                        maxi = k;
                    }
                }
                int sedl = min;
                if (max == min)
                {
                    lol++;
                    Console.WriteLine($"{lol}. [{maxi + 1},{mini + 1}] = {sedl}");
                }
            }
            if (lol == 0)
            {
                Console.WriteLine($"Седловых точек нет");
            }
        }
    }
}
