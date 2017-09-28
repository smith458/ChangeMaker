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
            List<int> denominations = new List<int> { 1 };
            int change = 1;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Changing_five_one()
        {
            List<int> denominations = new List<int> { 1 };
            int change = 5;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Changing_five_five()
        {
            List<int> denominations = new List<int> { 5 };
            int change = 5;
            int result = Program.CountChange(denominations, change);
            Assert.AreEqual(1, result);
        }
    }
}
