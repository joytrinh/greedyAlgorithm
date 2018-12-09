using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            decimal number;
            Console.WriteLine("Please give the amount in dollars to change: ");
            value = Console.ReadLine();
            if (decimal.TryParse(value, out number))
                Console.WriteLine(number);
            else
                Console.WriteLine("Unable to parse '{0}'",value);
            //Convert $ to cents
            decimal cents = number * 100;
            int count = 0;
            while (cents >= 25)
            {
                count++;
                cents = cents - 25;
            }
            while (cents >= 10)
            {
                count++;
                cents = cents - 10;
            }
            while (cents >= 5)
            {
                count++;
                cents = cents - 5;
            }
            while (cents >= 1)
            {
                count++;
                cents = cents - 1;
            }
            Console.WriteLine("The amount of coins to be returned is: " + count);
        }
    }
}
