using ChangeMaker;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangMaker.Test
{
    [TestFixture]
    public class When_single_item
    {
        [Test]
        public void Changing_one_one()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 1 };
            int result =  customCoins.CountChangeCombos(1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Changing_five_one()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 1 };
            int result = customCoins.CountChangeCombos(5);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Changing_five_five()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 5 };
            int result = customCoins.CountChangeCombos(5);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Changing_no_combos()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 5 };
            int result = customCoins.CountChangeCombos(1);
            Assert.AreEqual(0, result);
        }
    }
}
