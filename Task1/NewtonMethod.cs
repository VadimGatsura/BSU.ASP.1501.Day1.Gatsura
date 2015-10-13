using System;
using System.CodeDom;

namespace Task1 {
    public static class NewtonMethod {
        #region Static Methods
        /// <summary>Finding of root</summary>
        /// <param name="value">Value for which you want to search the root</param>
        /// <param name="n">Degree of root</param>
        /// <param name="precision">Precision of the found root<remarks>Must be greater than 0 and less than or equal 1</remarks></param>
        /// <returns>Root of <paramref name="n"/>-degree for the <paramref name="value"/></returns>
        public static double Root(double value, uint n, double precision) {
            if (precision < 0 || precision > 1) {
                throw new ArgumentException(nameof(precision));
            }

            if (value < 0 && n % 2 == 0)
                return double.NaN;
            if (Math.Abs(value) < Math.Abs(precision))
                return 0;
            double k = value;
            double x0 = value;
            double x1 = x0 - (Math.Pow(x0, n) - k)/(Math.Pow(x0, n - 1)*n);

            while (Math.Abs(x1 - x0) > precision) {
                x0 = x1;
                x1 = x0 - (Math.Pow(x0, n) - k)/(Math.Pow(x0, n - 1)*n);
            }

            for (int i = 0;; i++) {
                if (precision * Math.Pow(10, i) > 1)
                    return Math.Round(x1, i);
            }
        }
        #endregion
    }
}
