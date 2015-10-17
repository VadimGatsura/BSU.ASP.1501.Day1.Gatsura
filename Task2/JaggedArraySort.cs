// ReSharper disable InconsistentNaming
using System;
using System.Linq;

namespace Task2 {
    public abstract class JaggedArraySort {
        /// <summary>
        /// Compare two arrays
        /// </summary>
        /// <param name="array1">The first array for comparison</param>
        /// <param name="array2">The second array for comparison</param>
        /// <returns></returns>
        public delegate int CompareRows(int[] array1, int[] array2);

        #region Public Methods
        /// <summary>
        /// Sort jagged array by the <see cref="CompareRows"/> method
        /// <remarks>null sub-arrays go to the end of jagged array</remarks>
        /// </summary>
        /// <param name="array">Jagged array for sorting</param>
        /// <param name="Compare">Method, which allow compare two sub-arrays</param>
        public static void Sort(int[][] array, CompareRows Compare) {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            if (Compare == null)
                throw new ArgumentNullException(nameof(Compare));
            for (int i = array.Length - 1; i > 0; i--) {
                for (int j = 0; j < i; j++) {
                    if (Compare(array[j], array[j + 1]) > 0) {
                        Swap(ref array[j], ref array[j + 1]);
                    }    
                }       
            }    
        }

        #region Rows Compare Methods

        /// <summary>
        /// Compare two arrays by the minimum element in a row
        /// </summary>
        /// <param name="array1">The first array for comparison</param>
        /// <param name="array2">The second array for comparison</param>
        /// <returns></returns>
        public static int CompareMinRowElement(int[] array1, int[] array2) {
            if (array1 == null && array2 == null)
                return 0;
            if (array1 == null)
                return 1;
            if (array2 == null)
                return -1;
            int firstMin = array1.Min(), secondMin = array2.Min();
            if (firstMin == secondMin)
                return 0;
            if (firstMin > secondMin)
                return 1;
            return -1;
        }

        /// <summary>
        /// Compare two arrays by the sum of row elements
        /// </summary>
        /// <param name="array1">The first array for comparison</param>
        /// <param name="array2">The second array for comparison</param>
        /// <returns></returns>
        public static int CompareRowSum(int[] array1, int[] array2) {
            if (array1 == null && array2 == null)
                return 0;
            if (array1 == null)
                return 1;
            if (array2 == null)
                return -1;
            int firstSum = array1.Sum(), secondSum = array2.Sum();
            if (firstSum == secondSum)
                return 0;
            if (firstSum > secondSum)
                return 1;
            return -1;
        }

        /// <summary>
        /// Compare two arrays by the maximum element in a row
        /// </summary>
        /// <param name="array1">The first array for comparison</param>
        /// <param name="array2">The second array for comparison</param>
        /// <returns></returns>
        public static int CompareMaxRowElement(int[] array1, int[] array2) {
            if (array1 == null && array2 == null)
                return 0;
            if (array1 == null)
                return 1;
            if (array2 == null)
                return -1;
            int firstMax = array1.Max(), secondMax = array2.Max();
            if (firstMax == secondMax)
                return 0;
            if (firstMax > secondMax)
                return 1;
            return -1;
        }

        #endregion
        #endregion

        #region Private Methods
        private static void Swap(ref int[] firstArray, ref int[] secondArray) {
            int[] bufferArray = firstArray;
            firstArray = secondArray;
            secondArray = bufferArray;
        }
        #endregion
    }
}
