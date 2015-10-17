using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task2.JaggedArraySort;

namespace Task2.Test {
    [TestClass]
    public class JaggedArraySortTest {
        [TestMethod]
        public void TestAscRowSum() {
            int[][] array = { new []{4, 2, -1, 9, -8, 10}, new[]{0}, null, null, new []{4, 3, 8, 5,7} };
            int[][] testArray = { new[] { 0 }, new[] { 4, 2, -1, 9, -8, 10 }, new[] { 4, 3, 8, 5, 7 }, null, null };
            Sort(array, CompareRowSum);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestDescRowSum() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { null, null, new[] { 4, 3, 8, 5, 7 }, new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 } };
            Sort(array, CompareRowSum);
            array = array.Reverse().ToArray();

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestAscMaxElement() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { new[] { 0 }, new[] { 4, 3, 8, 5, 7 }, new[] { 4, 2, -1, 9, -8, 10 }, null, null };
            Sort(array, CompareMaxRowElement);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestDescMaxElement() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { null, null, new[] { 4, 2, -1, 9, -8, 10 }, new[] { 4, 3, 8, 5, 7 },  new[] { 0 }};
            Sort(array, CompareMaxRowElement);
            array = array.Reverse().ToArray();

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestAscMinElement() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, new[] { 4, 3, 8, 5, 7 }, null, null };
            Sort(array, CompareMinRowElement);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestDescMinElement() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { null, null, new[] { 4, 3, 8, 5, 7 },  new[] { 0 }, new[] { 4, 2, -1, 9, -8, 10 } };
            Sort(array, CompareMinRowElement);
            array = array.Reverse().ToArray();

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullArray() {
            Sort(null, CompareRowSum);
        }
    }
}
