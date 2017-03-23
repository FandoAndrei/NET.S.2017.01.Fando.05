using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematiciansMethods
{
    class MathMethod
    {

        #region Public members part



        public static int EuclideanGCDMethodCall(int a, int b)
        {
           return EuclideanGCDMethod(a,b);
        }

        public static int EuclideanGCDMethodCall(int a, int b, int c)
        {
           return EuclideanGCDMethod(EuclideanGCDMethod(a,b),c);
        }

        /// <summary>
        /// This method'll be called when nomber of GCD values is greater than 3.
        /// </summary>
        /// <param name="values">This is an array of values.</param>
        /// <returns>The GCD of entire array <param>values</param>. If number of <param>values</param> equals to 0 returns (-1) </returns>

        public static int EuclideanGCDMethodCall(params int[] values)
        {

            int gcd;
            if (values.Length!=0)
            {
                gcd = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    gcd = EuclideanGCDMethod(gcd, values[i]);
                }
                return gcd;
            }
            else return -1;      
        }

        #endregion;

        #region Private members part

        /// <summary>
        /// EuclideanGCDMethod is a method for counting the Greatest Common Devisor(GCD) of two integers.
        /// As soon as there is no difference between GCD of positive or negative values, we make them both positive.
        /// </summary>
        /// <returns>The GCD of values (a,b), if any of them equals to 0, returns -1</returns>
        private static int EuclideanGCDMethod(int value_a, int value_b)
        {
            if (IsValid(value_a, value_b))
            {
                if (value_a < 0)
                    value_a *= (-1);
                if (value_b < 0)
                    value_b *= (-1);

                while (value_a != value_b)
                {
                    if (value_a > value_b)
                        value_a = value_a - value_b;
                    else
                        value_b = value_b - value_a;
                }
                return value_a;
            }
            return -1;
        }

        #endregion

        #region Imput validation methods

        /// <summary>
        /// Validates imput data for evaluation method.
        /// </summary>
        /// <param name="value_a">first number</param>
        /// <param name="value_b">second number</param>
        /// <returns>True if nine of <param>a</param> and <param>b</param> equals to 0, other way - False</returns>

        private static bool IsValid(int value_a, int value_b)
        {
            if (value_a != 0)
                if (value_b != 0)
                    return true;
                else
                    return false;
            else
                return false;
        }

        #endregion

    }
}
