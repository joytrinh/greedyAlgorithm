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
            /*
            1$ = 100cents
            1 quarter = 25cents
            1 dime = 10cents
            1 nickel = 5cents
            1 penny = 1cent
            the heart of the greedy algorithm, which is always using the largest coin possible
            prompt the user for an amount of change
            - The amount must make sense
            - What values are accepted
            - get_float
            always use the largest coin possible
            - How many coins to be returned
            - amount to be returned
            keep track of coins used
            print the final number of coins
            */
            string value;
            decimal number;
            Console.WriteLine("Please give the amount in dollars to change: ");
            value = Console.ReadLine();
            if (decimal.TryParse(value, out number))
                Console.WriteLine(number);
            else
                Console.WriteLine("Unable to parse '{0}'",value);

        }
    }
}
