using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleType.Core
{
    internal class ProverkaType
    {
        public int Proverka(int i, string s) 
        {

            start:

            Console.Write(s);
            if (int.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else 
            {
                goto start;
            }
        }
    }
}
