using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class FizzBuzz
    {
        #region Version 1
        //public static string Print(int number)
        //{
        //    return number.ToString();
        //}

        #endregion

        #region Version 2
        //public static string Print(int number)
        //{
        //    if (number % 3 == 0) return "Fizz";
        //    return number.ToString();
        //}
        #endregion

        #region Version 3
        //public static string Print(int number)
        //{
        //    if (number % 3 == 0) return "Fizz";
        //    if (number % 5 == 0) return "Buzz";
        //    return number.ToString();
        //}
        #endregion

        #region Version 4
        //public static string Print(int number)
        //{
        //    if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz";
        //    if (number % 3 == 0) return "Fizz";
        //    if (number % 5 == 0) return "Buzz";
        //    return number.ToString();
        //}
        #endregion


        #region Version 5 (Refactor)
        public static string Print(int number)
        {
            if (IsFizz(number) && IsBuzz(number)) return "FizzBuzz";
            if (IsFizz(number)) return "Fizz";
            if (IsBuzz(number)) return "Buzz";
            return number.ToString();
        }

        private static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
        #endregion

    }
}
