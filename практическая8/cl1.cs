using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая8
{
    internal class cl1
    {
        public Random rn = new Random();

        public int[] lg(int d, int h)
        {
            string[,] word = new string[,] { { "сок", "тон", "лёд", "кит", "риф" }, { "тишь", "гора", "фото", "трон", "плащ" }, { "озеро", "гараж", "бомба", "пауза", "мусор" }, { "корона", "машина", "яблоко", "основа", "цветок" } };
            int ss = rn.Next(0, 3);
            int s = rn.Next(0, 4);
            string pr = word[ss, s];
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("=============================");
            Console.SetCursorPosition(60, 1);
            Console.WriteLine(pr);
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("=============================");
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("=============================");
            Console.SetCursorPosition(60, 3);
            string b = Console.ReadLine();
            if (b == pr)
            {
                if (ss == 0)
                {
                    d = d + 3;
                }
                if (ss == 1)
                {
                    d = d + 4;
                }
                if (ss == 2)
                {
                    d = d + 5;
                }
                if (ss == 3)
                {
                    d = d + 6;
                }
            }
            else
            {
                h++;
            }
            Console.SetCursorPosition(60, 1);
            Console.WriteLine("           ");
            Console.SetCursorPosition(60, 3);
            Console.WriteLine("           ");

            int[] ints = new int[] { d, h };
            return ints;
        }

    }
}
