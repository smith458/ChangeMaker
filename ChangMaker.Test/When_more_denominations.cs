using ChangeMaker;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangMaker.Test
{
    class When_more_denominations
    {
        [Test]
        public void Changing_23_standard()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 10, 5, 1 };
            int result = customCoins.CountChangeCombos(23);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Changing_35_standard()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 25, 10, 5, 1 };
            int result = customCoins.CountChangeCombos(35);
            Assert.AreEqual(24, result);
        }

        [Test]
        public void Changing_27_by_15_and_3()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 15, 3 };
            int result = customCoins.CountChangeCombos(27);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Changing_27_by_15_3_and_1()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 15, 3, 1 };
            int result = customCoins.CountChangeCombos(27);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Changing_8_by_3_2_and_1()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 3, 2, 1 };
            int result = customCoins.CountChangeCombos(8);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Changing_137_by_100_50_10_and_1()
        {
            CurrencySystem customCoins = new CurrencySystem();
            customCoins.Denominations = new List<int> { 100, 50, 10, 1 };
            int result = customCoins.CountChangeCombos(137);
            Assert.AreEqual(31, result);
        }
    }
}
