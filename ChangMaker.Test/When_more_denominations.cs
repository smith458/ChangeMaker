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
            List<int> denominations = new List<int> { 10, 5, 1 };
            int change = 23;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Changing_35_standard()
        {
            List<int> denominations = new List<int> { 25, 10, 5, 1 };
            int change = 35;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(24, result);
        }

        [Test]
        public void Changing_27_by_15_and_3()
        {
            List<int> denominations = new List<int> { 15, 3 };
            int change = 27;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Changing_27_by_15_3_and_1()
        {
            List<int> denominations = new List<int> { 15, 3, 1 };
            int change = 27;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Changing_8_by_3_2_and_1()
        {
            List<int> denominations = new List<int> { 3, 2, 1 };
            int change = 8;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Changing_137_by_100_50_10_and_1()
        {
            List<int> denominations = new List<int> { 100, 50, 10, 1 };
            int change = 137;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(31, result);
        }
    }
}
