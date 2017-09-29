using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    public class CurrencySystem
    {
        public CurrencySystem()
        {
            denominations = new List<int>() { 1 };
        }

        public int CountChangeCombos(int n)
        {
            return recurseChangeCombos(denominations, n);
        }

        private static int recurseChangeCombos(List<int> denoms, int n, int count = 0)
        {
            if (denoms.Count() == 1)
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
                count = recurseChangeCombos(denoms.Skip(1).ToList(), left, count);
            }

            return count;
        }

        private List<int> denominations;

        public List<int> Denominations
        {
            get { return denominations; }
            set
            {
                if (value.Any() && !value.Contains(0))
                {
                    denominations = value.OrderByDescending(x=>x).ToList();
                }
            }
        }
    }
}
