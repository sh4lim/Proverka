using ConsoleType.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleType
{
    internal class Program
    {
        static Random rand = new Random();

        static int max;
        static int min;
        static void Main(string[] args)
        {
            while(true)
            {
                start:
                ProverkaType proverkaType = new ProverkaType();

                min = proverkaType.Proverka(min, "Введите мин число =>");

                max = proverkaType.Proverka(max, "Введите макс число =>");

                Console.Write($"\nМин:{min} Макс:{max} \n\n");

                if( min > max ) { Console.WriteLine("Минимальное число не может быть больше максимального!\n"); goto start; }

                Console.Write($"\n{rand.Next(min, max)}\n\n");
            }

        }
    }
}
