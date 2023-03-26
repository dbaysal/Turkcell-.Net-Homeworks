using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    /// <summary>
    /// BinaryOperations class is only responsible for getting an instruction,
    /// and returning it into 2 integer operators. (SRP)
    /// </summary>
    public class BinaryOperations
    {

        public static List<int> GetOperators(string instruction)
        {
            List<int> myOperators = new List<int>();
            string firstOperator = instruction.Substring(3, 4);
            string secondOperator = instruction.Substring(7);

            myOperators.Add(GetSingleOperator(firstOperator));
            myOperators.Add(GetSingleOperator(secondOperator));

            return myOperators;

        }

        public static int GetSingleOperator(string singleOperator)
        {
            return Convert.ToInt32(singleOperator, 2);
        }

    }
}
