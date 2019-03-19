using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skat.Tests
{
    [TestClass()]
    public class AfgiftTests
    {
        [TestMethod()]
        public void BilafgiftTestLav()
        {
            Afgift afgift1 = new Afgift();

            var expected = 170000;
            var actual = afgift1.Bilafgift(200000);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BilafgiftTestHøj()
        {
            Afgift afgift2 = new Afgift();

            var expected = 320000;
            var actual = afgift2.Bilafgift(300000);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ElbilafgiftTestLav()
        {
            Afgift afgift3 = new Afgift();

            var expected = 34000;
            var actual = afgift3.ElBilAfgift(200000);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ElbilafgiftTestHøj()
        {
            Afgift afgift4 = new Afgift();

            var expected = 64000;
            var actual = afgift4.ElBilAfgift(300000);

            Assert.AreEqual(expected, actual);
        }


    
    }
}