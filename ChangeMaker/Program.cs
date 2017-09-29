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
            CurrencySystem customCoins = new CurrencySystem();
            List<int> denominations = RequestPosIntList("What currencies would you like to use? Enter one at a time and enter a 0 when complete.");
            customCoins.Denominations = denominations;

            int changeAmount = RequestPosInt("What amount would you like to make change for?");
            int combinations = customCoins.CountChangeCombos(changeAmount);

            Console.WriteLine("");
            Console.WriteLine($"{combinations} ways");
            Console.ReadLine();
        }

        public static int RequestPosInt(string request)
        {
            int val;
            bool result;

            while (true)
            {
                Console.WriteLine(request);
                result = int.TryParse(Console.ReadLine(), out val);
                if (result && val > 0)
                {
                    break;
                }
            }
            return val;
        }

        public static List<int> RequestPosIntList(string request)
        {
            int val;
            bool result;
            List<int> valList = new List<int>();

            while (true)
            {
                Console.WriteLine(request);
                result = int.TryParse(Console.ReadLine(), out val);
                if (result)
                {
                    if (val > 0)
                    {
                        valList.Add(val);
                    }
                    else if (val == 0)
                    {
                        break;
                    }
                }
            }

            return valList;
        }

    }
}
