using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2.Test {
    [TestClass]
    public class JaggedArraySortTest {
        [TestMethod]
        public void TestAscRowSum() {
            int[][] array = { new []{4, 2, -1, 9, -8, 10}, new[]{0}, null, null, new []{4, 3, 8, 5,7} };
            int[][] testArray = { new[] { 0 }, new[] { 4, 2, -1, 9, -8, 10 }, new[] { 4, 3, 8, 5, 7 }, null, null };
            JaggedArraySort.SortByRowSum(array, true);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestDescRowSum() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { new[] { 4, 3, 8, 5, 7 }, new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null };
            JaggedArraySort.SortByRowSum(array, false);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestAscMaxElement() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { new[] { 0 }, new[] { 4, 3, 8, 5, 7 }, new[] { 4, 2, -1, 9, -8, 10 }, null, null };
            JaggedArraySort.SortByMaxRowElement(array, true);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestDescMaxElement() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 4, 3, 8, 5, 7 },  new[] { 0 }, null, null };
            JaggedArraySort.SortByMaxRowElement(array, false);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestAscMinElement() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, new[] { 4, 3, 8, 5, 7 }, null, null };
            JaggedArraySort.SortByMinRowElement(array, true);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        public void TestDescMinElement() {
            int[][] array = { new[] { 4, 2, -1, 9, -8, 10 }, new[] { 0 }, null, null, new[] { 4, 3, 8, 5, 7 } };
            int[][] testArray = { new[] { 4, 3, 8, 5, 7 },  new[] { 0 }, new[] { 4, 2, -1, 9, -8, 10 }, null, null };
            JaggedArraySort.SortByMinRowElement(array, false);

            IStructuralEquatable arrays = array;

            Assert.AreEqual(arrays.Equals(testArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullArray() {
            JaggedArraySort.SortByRowSum(null, true);
        }
    }
}
