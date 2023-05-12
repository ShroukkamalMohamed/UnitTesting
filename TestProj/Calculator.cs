using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    public class Calculator
    {
        public int FristNumber { get; set; }
        public int SecNumber { get; set; }
        public string OperationType { get; set; }

        public int Calucluation()
        {
            switch (OperationType)
            {
                case "Add":
                    return FristNumber + SecNumber;
                case "SubStract":
                    return FristNumber + SecNumber;
                default:
                    throw new Exception("Operation Type Is Not Exist");

            }
        }
        public int MaxNumber(int FristNumber, int SecNumber)
        {
            return (FristNumber > SecNumber) ? FristNumber : SecNumber;
        }
        public IEnumerable<int> OddNumbers(int Number)
        {
            List<int> Numblst = new List<int>();
            for (int i = 0; i < Number; i++)
            {
                if (i % 2 == 0)
                {
                    Numblst.Add(i);    
                }
            }
            return Numblst;
        }
    }
}
