using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays_1_dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of arrays
            int[] LuckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(LuckyNumbers.Length);
            Console.WriteLine(LuckyNumbers[0]);

            string[] friends = new string[5];
            friends[0] = "Aphiwe";
            friends[1] = "Mukelo";
            friends[2] = "Luyandah";
            friends[3] = "Ayaan";

            Console.WriteLine(friends[3]);
            
            //freeze the console
            Console.ReadLine();
        }
    }
}
