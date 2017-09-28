using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int changeAmount;
            int coinVal;
            List<int> denominations = new List<int>();

            while (true)
            {
                Console.WriteLine("What amount would you like to make change for?");
                result = int.TryParse(Console.ReadLine(), out changeAmount);
                if (result && changeAmount > 0) { break; }
            }

            while (true)
            {
                Console.WriteLine("What currencies would you like to use? Enter a 0 when complete.");
                result = int.TryParse(Console.ReadLine(), out coinVal);
                if (result)
                {
                    if (coinVal > 0)
                    {
                        denominations.Add(coinVal);
                    }
                    else if (coinVal == 0)
                    {
                        break;
                    }
                }
            }

            int combinations = CountChange(denominations.OrderByDescending(x => x).ToList(), changeAmount);
            Console.WriteLine("");
            Console.WriteLine($"{combinations} ways");
            Console.ReadLine();
        }

        public static int CountChange(List<int> denoms, int n, int count=0)
        {
            if (denoms.Count()==1)
            {
                if (n % denoms[0] == 0)
                {
                    return ++count;
                }
                else
                {
                    return count;
                }
            }

            int max = n / denoms[0];

            for (int x = 0; x <= max; x++)
            {
                int left = n - x * denoms[0];
                count = CountChange(denoms.Skip(1).ToList(), left, count);
            }

            return count;
        }
    }
}
