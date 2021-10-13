using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    static class Extension
    {
        public static void Polendron(this int number)
        {
            int sum = 0;
            for (int i = number; i > 0; i /= 10)
            {
                sum = (sum * 10) + i % 10;
            }
            if (number == sum)
            {
                Console.WriteLine("polendrom ededdir");
            }
            else
            {
                Console.WriteLine("polendrom eded deyil");
            }
        }
    }
}
