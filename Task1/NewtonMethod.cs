using System;


namespace Task1 {
    public static class NewtonMethod {
        #region Static Methods
        /// <summary>Finding of root</summary>
        /// <param name="value">Value for which you want to search the root</param>
        /// <param name="n">Degree of root</param>
        /// <param name="precision">Precision of root</param>
        /// <returns>Root of <paramref name="n"/>-degree for the <paramref name="value"/></returns>
        public static double Root(double value, uint n, double precision) {
            if(precision < 1E-16 || precision > 1)
                throw new ArgumentOutOfRangeException(nameof(precision));

            if (value < 0 && n % 2 == 0)
                return double.NaN;

            if (Math.Abs(value) < precision)
                return 0;

            double x0, x1 = value, k = value; 

            do {
                x0 = x1;
                x1 = x0 - (Math.Pow(x0, n) - k)/(Math.Pow(x0, n - 1)*n);
            } while (Math.Abs(x1 - x0) > precision);


            return x1;
        }
        #endregion
    }
}
