using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   
        public class StringCalculator
        {
            public  int Add(string numbers)
            {
                if (string.IsNullOrEmpty(numbers))
                {
                    return 0;
                }

                var delimiters = new[] { ',', '\n' };
                var numberStrings = numbers.Split(delimiters);

                var negatives = numberStrings.Where(n => int.Parse(n) < 0).ToList();
                if (negatives.Any())
                {
                    throw new Exception($"negatives not allowed: {string.Join(",", negatives)}");
                }

                return numberStrings.Sum(n => int.Parse(n));
            }
        }
    }

