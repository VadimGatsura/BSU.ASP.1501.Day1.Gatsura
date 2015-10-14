using System;

namespace Task1 {
    public abstract class NewtonMethod {
        #region Static Methods
        /// <summary>Finding of root</summary>
        /// <param name="value">Value for which you want to search the root</param>
        /// <param name="n">Degree of root</param>
        /// <param name="digits">The number of fractional digits in root<remarks>Must be between 0 and 15, included 15</remarks></param>
        /// <returns>Root of <paramref name="n"/>-degree for the <paramref name="value"/></returns>
        public static double Root(double value, uint n, uint digits) {
            if(digits > 15)
                throw new ArgumentOutOfRangeException(nameof(digits));

            if (value < 0 && n % 2 == 0)
                return double.NaN;

            if (Math.Abs(value) < Math.Pow(0.1, digits))
                return 0;

            double x0, x1 = value, k = value; 

            do {
                x0 = x1;
                x1 = x0 - (Math.Pow(x0, n) - k)/(Math.Pow(x0, n - 1)*n);
            } while (Math.Abs(x1 - x0) > Math.Pow(0.1, digits));

            return Math.Round(x1, (int) digits);
        }
        #endregion
    }
}
