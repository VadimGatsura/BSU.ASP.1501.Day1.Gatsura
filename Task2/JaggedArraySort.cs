using System;
using System.Linq;

namespace Task2 {
    public abstract class JaggedArraySort {
        
        private delegate int CompareRows(int[] array1, int[] array2);

        #region Private Methods
        private static void Sort(int[][] array, bool asc, CompareRows Compare) {
            for (int i = array.Length - 1; i > 0; i--) {
                for (int j = 0; j < i; j++) {
                    if (asc && Compare(array[j], array[j + 1]) > 0) {
                        Swap(ref array[j], ref array[j + 1]);
                    } else if (!asc && Compare(array[j], array[j + 1]) < 0) {  
                        Swap(ref array[j], ref array[j + 1]);
                    }   
                }       
            }    
        }

        private static void Swap(ref int[] firstArray,ref int[] secondArray) {
            int[] bufferArray = firstArray;
            firstArray = secondArray;
            secondArray = bufferArray;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Sorting array by the sum of row elements
        /// </summary>
        /// <param name="array">Jagged array for sorting</param>
        /// <param name="asc">Sorting direction. <remarks>true - ascending, false - descending</remarks></param>
        public static void SortByRowSum(int[][] array, bool asc) {
            if(array == null)
                throw new ArgumentNullException(nameof(array));

            Sort(array, asc, (array1, array2) => {
                    if (array1 == null && array2 == null)
                        return 0;
                    if (array1 == null)
                        return asc ? 1 : -1;
                    if (array2 == null)
                        return asc ? -1 : 1;
                    int firstSum = array1.Sum(), secondSum = array2.Sum();
                    if (firstSum == secondSum)
                        return 0;
                    if (firstSum > secondSum)
                        return 1;
                    return -1;
            });
        }

        /// <summary>
        /// Sorting array by the maximum element in row
        /// </summary>
        /// <param name="array">Jagged array for sorting</param>
        /// <param name="asc">Sorting direction. <remarks>true - ascending, false - descending</remarks></param>
        public static void SortByMaxRowElement(int[][] array, bool asc) {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            Sort(array, asc, (array1, array2) => {
                if (array1 == null && array2 == null)
                    return 0;
                if (array1 == null)
                    return asc ? 1 : -1;
                if (array2 == null)
                    return asc ? -1 : 1;
                int firstMax = array1.Max(), secondMax = array2.Max();
                if (firstMax == secondMax)
                    return 0;
                if (firstMax > secondMax)
                    return 1;
                return -1;
            });
        }

        /// <summary>
        /// Sorting an array by the minimum element in row
        /// </summary>
        /// <param name="array">Jagged array for sorting</param>
        /// <param name="asc">Sorting direction. <remarks>true - ascending, false - descending</remarks></param>
        public static void SortByMinRowElement(int[][] array, bool asc) {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            Sort(array, asc, (array1, array2) => {
                if (array1 == null && array2 == null)
                    return 0;
                if (array1 == null)
                    return asc ? 1 : -1;
                if (array2 == null)
                    return asc ? -1 : 1;
                int firstMin = array1.Min(), secondMin = array2.Min();
                if (firstMin == secondMin)
                    return 0;
                if (firstMin > secondMin)
                    return 1;
                return -1;
            });
        }
        #endregion
    }
}
