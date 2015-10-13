using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1.Test {
    [TestClass]
    public class NewtonMethodTest {
        [TestMethod]
        public void TestRootValue() {
            Assert.AreEqual( NewtonMethod.Root(4,2,0.000001), Math.Round(Math.Pow(4, 1.0 / 2), 6) );
            Assert.AreEqual( NewtonMethod.Root(32, 5, 0.000001), Math.Round(Math.Pow(32, 1.0 / 5), 6) );

            Assert.AreEqual( NewtonMethod.Root(2, 3, 0.000001), Math.Round(Math.Pow(2, 1.0 / 3), 6) );
            Assert.AreEqual( NewtonMethod.Root(0, 2, 0.000001), Math.Round(Math.Pow(0, 1.0 / 2), 6) );

            Assert.AreEqual( NewtonMethod.Root(-8, 3, 0.000001), Math.Round(Math.Pow(8, 1.0 / 3), 6) * (-1) );  //multiple by (-1), because MathPow(-8, 1.0 / 3) return NaN. That's not true.

        }

        [TestMethod]
        public void TestPrecision() {
            Assert.AreEqual( NewtonMethod.Root(10, 2, 0.000001), 3.162277, 0.000001 );
            Assert.AreEqual( NewtonMethod.Root(10, 2, 1), 3, 1 );
        }

        [TestMethod]
        public void TestNaN() {
            Assert.AreEqual( NewtonMethod.Root(-2, 2, 0.000001), Math.Round(Math.Pow(-2, 1d / 2), 6) );
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArgumentExceptions() {
            NewtonMethod.Root(2, 2, -1);
            NewtonMethod.Root(2, 2, 1.3);
            NewtonMethod.Root(2, 2, 0);
        }
    }
}
