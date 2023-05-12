using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj.Exercises
{
    public class FizzBuzz
    {
        public string GetType(int Number)
        {
            if ((Number % 3 == 0) && (Number % 5 == 0))
            {
                return "FizzBuzz";
            }
            if (Number % 3 == 0)
            {
                return "Fizz";
            }
            if(Number % 5 == 0)
            {
                return "Buzz";
            }
            return Number.ToString();
        }
    }
}
