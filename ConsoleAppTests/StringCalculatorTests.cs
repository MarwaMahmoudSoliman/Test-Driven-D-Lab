using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace StringCalculatorTests
    {
        [TestClass]
        public class StringCalculatorTests
        {
            [TestMethod]
            public void Add_EmptyString_ReturnsZero()
            {
                var calculator = new StringCalculator();
                int result = calculator.Add("");
                Assert.AreEqual(0, result);
            }

            [TestMethod]
            public void Add_SingleNumber_ReturnsSameNumber()
            {
                var calculator = new StringCalculator();
                int result = calculator.Add("1");
                Assert.AreEqual(1, result);
            }

            [TestMethod]
            public void Add_TwoNumbers_ReturnsSum()
            {
                var calculator = new StringCalculator();
                int result = calculator.Add("1,2");
                Assert.AreEqual(3, result);
            }

            [TestMethod]
            public void Add_UnknownAmountOfNumbers_ReturnsSum()
            {
                var calculator = new StringCalculator();
                int result = calculator.Add("1,2,3,4,5");
                Assert.AreEqual(15, result);
            }

            [TestMethod]
            public void Add_NewLineDelimiter_ReturnsSum()
            {
                var calculator = new StringCalculator();
                int result = calculator.Add("1\n2,3");
                Assert.AreEqual(6, result);
            }

            [TestMethod]
            [ExpectedException(typeof(System.Exception), "negatives not allowed: -1")]
            public void Add_NegativeNumber_ThrowsException()
            {
                var calculator = new StringCalculator();
                calculator.Add("-1");
            }

            [TestMethod]
            [ExpectedException(typeof(System.Exception), "negatives not allowed: -1,-2")]
            public void Add_MultipleNegativeNumbers_ThrowsExceptionWithAll()
            {
                var calculator = new StringCalculator();
                calculator.Add("-1,-2");
            }
        }
    }

