using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor_TDD
{
    [TestFixture]
    public class PrimeFactorTest
    {
        private List<int> List(params int[] numbers)
        {
            var newNumbers = new List<int>();
            foreach (var n in numbers)
            {
                newNumbers.Add(n);
            }
            return newNumbers;
        }


        [Test]

        public void TestOne()
        {
            Assert.That(PrimeFactor.Genarate(1),Is.EqualTo(new List<int>()));
        }

        [Test]
        public void TestTwo()
        {
            Assert.That(PrimeFactor.Genarate(2), Is.EqualTo(List( 2)));

        }

        [Test]
        public void TesThree()
        {
            Assert.That(PrimeFactor.Genarate(3), Is.EqualTo(List( 3 )));

        }

        [Test]
        public void TestFour()
        {
            Assert.That(PrimeFactor.Genarate(4), Is.EqualTo(List(2,2 )));

        }

        [Test]
        public void TestFive()
        {
            Assert.That(PrimeFactor.Genarate(5), Is.EqualTo(List(5 )));

        }

        [Test]
        public void TestSix()
        {
            Assert.That(PrimeFactor.Genarate(6), Is.EqualTo(List(2,3 )));

        }

        [Test]
        public void TestSeven()
        {
            Assert.That(PrimeFactor.Genarate(7), Is.EqualTo(List(7 )));

        }

        [Test]
        public void TestEight()
        {
            Assert.That(PrimeFactor.Genarate(8), Is.EqualTo(List(2, 2,2 )));

        }

        [Test]
        public void TestNine()
        {
            Assert.That(PrimeFactor.Genarate(9), Is.EqualTo(List(3,3)));

        }

        [Test]
        public void TestMain()
        {
            Assert.That(PrimeFactor.Genarate(84), Is.EqualTo(List(2, 2, 3, 7)));

        }
    }
}
