using ConsoleApp;

namespace ConsoleAppTests
{
    [TestClass]
    public class FizzBuzzTests
    {


        [TestMethod]
        public void Print_Number1_Print1()
        {
            var result = FizzBuzz.Print(1);

            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("1"));
        }

        [TestMethod]
        public void Print_Number4_Print4()
        {
            var result = FizzBuzz.Print(4);

            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("4"));
        }

        [TestMethod]
        public void Print_Number3_PrintFizz()
        {
            var result = FizzBuzz.Print(3);

            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("Fizz"));
        }

        [TestMethod]
        public void Print_Number9_PrintFizz()
        {
            var result = FizzBuzz.Print(9);

            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("Fizz"));
        }

        [TestMethod]
        public void Print_Number5_PrintBuzz()
        {
            var result = FizzBuzz.Print(5);

            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("Buzz"));
        }

        [TestMethod]
        public void Print_Number25_PrintBuzz()
        {
            var result = FizzBuzz.Print(25);

            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("Buzz"));
        }

        [TestMethod]
        public void Print_Number30_PrintFizzBuzz()
        {
            var result = FizzBuzz.Print(30);

            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("FizzBuzz"));
        }

        [TestMethod]
        public void Print_Number45_PrintFizzBuzz()
        {
            var result = FizzBuzz.Print(45);

            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("FizzBuzz"));
        }
    }
}