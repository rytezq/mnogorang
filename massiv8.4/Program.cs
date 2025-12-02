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
            string[,] crestiki =
            {
                {"X", "O", "X"},
                {"0", "X", "O"},
                {"O", "0", "X"},
            };
            for (int i = 0; i < crestiki.GetLength(0); i++)
            {
                for (int j = 0; j < crestiki.GetLength(1); j++)
                {
                    Console.Write(crestiki[i, j] + " ");
                }
                Console.WriteLine();
            }
            string lol = "0";
            for (int i = 0;i < 3; i++)
            {
                if (crestiki[i, 0] != "0" && crestiki[i, 0] == crestiki[i, 1] && crestiki[i, 1] == crestiki[i, 2])
                {
                    lol = crestiki[i, 0];
                }
                if (crestiki[0, i] != "0" && crestiki[0, i] == crestiki[1, i] && crestiki[1, i] == crestiki[2, i])
                {
                    lol = crestiki[0, i];
                }
            }
            if (crestiki[0, 0] != "0" && crestiki[0, 0] == crestiki[1, 1] && crestiki[1,1] == crestiki[2, 2])
            {
                lol = crestiki[0, 0];
            }
            if (crestiki[0, 2] != "0" && crestiki[0, 0] == crestiki[1, 1] && crestiki[1, 1] == crestiki[2, 0])
            {
                lol = crestiki[0, 2];
            }
            Console.WriteLine(lol == "X" ? "победили крестики" : lol == "O" ? "Победители нолики" : "Победителей нету");
        }
    }
}
