using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private readonly List<int> _numbers = new List<int>();

        public int Add()
        {
            return _numbers.Sum();
        }

        public void Enter(int p0)
        {
            _numbers.Add(p0);
        }
    }
}
