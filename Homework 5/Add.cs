using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{

    /// <summary>
    /// Class for addition, its only job is to define IOperate methods
    /// and getting the result by using two integer values (SRP)
    /// </summary>
    public class Add : IOperate
    {
        public int GetResult(string instruction)
        {
            return Addition(instruction);
        }
        public string GetOpCode()
        {
            return "000";
        }

        public int Addition(string instruction)
        {
            List<int> operators = BinaryOperations.GetOperators(instruction);
            int result = operators[0] + operators[1];

            return result;
        }

    }
}
