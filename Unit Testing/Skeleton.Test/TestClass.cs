using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            var axe = new Axe(10, 10);
            var dummy=new Dummy(10,10);

            axe.Attack(dummy);

            Assert.AreEqual(9,axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }
    }
}
