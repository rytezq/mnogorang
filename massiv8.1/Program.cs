using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace massiv8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ms = new int[4, 4];
            int num = 1;
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                for (int j = 0; j < ms.GetLength(1); j++)
                {
                    ms[i, j] = num;
                    num++;
                    Console.Write(ms[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
