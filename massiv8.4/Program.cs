using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] lol = new string[3, 3];
            string[] cresnol = { "X", "O", "-" };
            Random r = new Random();
            for (int i = 0; i < lol.GetLength(0); i++)
            {
                for (int j = 0; j < lol.GetLength(1); j++)
                {
                    lol[i, j] = cresnol[r.Next(0, 3)];
                    Console.Write(lol[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            string letter = "-";
            for (int i = 0; i < 3; i++)
            {
                if (lol[i, 0] != "-" && lol[i, 0] == lol[i, 1] && lol[i, 1] == lol[i, 2])
                {
                    letter = lol[i, 0];
                }
                if (lol[0, i] != "-" && lol[0, i] == lol[1, i] && lol[1, i] == lol[2, i])
                {
                    letter = lol[0, i];
                }
            }
            if (lol[0, 0] != "-" && lol[0, 0] == lol[1, 1] && lol[1, 1] == lol[2, 2])
            {
                letter = lol[0, 0];
            }
            if (lol[0, 2] != "-" && lol[0, 2] == lol[1, 1] && lol[1, 1] == lol[2, 0])
            {
                letter = lol[0, 2];
            }
            Console.WriteLine(letter == "X" ? "Победили крестики" : letter == "O" ? "Победили нолики" : "Нет победителей");
        }
    }
}
