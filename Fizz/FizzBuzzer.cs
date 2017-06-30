using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz
{
    public class FizzBuzzer
    {
        private Dictionary<int, string> _divisors;
        private int _upperBound;

        public FizzBuzzer()
        {
            Dictionary<int, string> divisors = new Dictionary<int, string>();
            divisors.Add(3, "Fizz");
            divisors.Add(5, "Buzz");
            SetDivisors(divisors);
            SetUpperBound(100);
        }

        public FizzBuzzer(Dictionary<int, string> divisors, int upperBound)
        {
            SetDivisors(divisors);
            SetUpperBound(upperBound);
        }

        public void SetDivisors(Dictionary<int, string> divisors)
        {
            _divisors = divisors;
        }

        public void SetUpperBound(int upperBound)
        {
            _upperBound = upperBound;
        }

        public List<string> Run()
        {
            List<string> results = new List<string>();
            for (int i = 1; i <= _upperBound; i++)
            {
                List<string> tempList = new List<string>();
                foreach (var d in _divisors)
                    if (i % d.Key == 0)
                        tempList.Add(d.Value);
                if (tempList.Count == 0)
                    results.Add(i.ToString());
                else if (tempList.Count == 1)
                    results.Add(tempList[0]);
                else
                    results.Add(string.Join(", ", tempList));
            }
            return results;
        }
    }
}
