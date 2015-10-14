using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1.Test {
    [TestClass]
    public class NewtonMethodTest {
        [TestMethod]
        public void TestIntRootValue() {
            Assert.AreEqual( NewtonMethod.Root(32, 5, 6), Math.Pow(32, 1.0 / 5), 0.000001  );
        }

        [TestMethod]
        public void TestDoubleRootValue() {
            Assert.AreEqual(NewtonMethod.Root(32, 7, 6), Math.Pow(32, 1.0/7), 0.000001);
        }

        [TestMethod]
        public void TestNaNValue() {
            Assert.AreEqual(NewtonMethod.Root(double.NaN, 4, 5), double.NaN);
        }

        [TestMethod]
        public void TestPrecision() {
            Assert.AreEqual( NewtonMethod.Root(10, 2, 1), 3, 1 );
        }

        [TestMethod]
        public void TestMaxPrecision() {
            Assert.AreEqual(NewtonMethod.Root(10, 2, 15), Math.Pow(10, 1.0 / 2), 0.000000000000001);
        }

        [TestMethod]
        public void TestNaNRoot() {
            Assert.AreEqual( NewtonMethod.Root(-2, 2, 6), Math.Round(Math.Pow(-2, 1d / 2), 6) );
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestArgumentExceptions() {
            NewtonMethod.Root(2, 2, 16);
        }


        [TestMethod]
        public void TestDoubleValue() {
            Assert.AreEqual( NewtonMethod.Root(5.6, 2, 6), Math.Pow(5.6, 1.0 / 2), 0.000001);
        }

        [TestMethod]
        public void TestNegativeValue() {
            Assert.AreEqual(NewtonMethod.Root(-8, 3, 6), Math.Pow(8, 1.0 / 3) * (-1), 0.000001);  //multiple by (-1), because MathPow(-8, 1.0 / 3) return NaN. That's not true.    
        }

        [TestMethod]
        public void TestZeroValue() {
            Assert.AreEqual(NewtonMethod.Root(0, 2, 6), Math.Pow(0, 1.0 / 2), 0.000001);
        }

    }
}
