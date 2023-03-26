using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    /// <summary>
    /// Decoder Class is only responsible from decoding an instruction and returning to the result
    /// of that instruction. (SRP)
    /// </summary>
    public class Decoder
    {
        public static int Decode(string instruction)
        {
            string OpCode = GetOpCode(instruction);
            IOperate? operationClass = GetOperationClass(OpCode);
            int result = operationClass.GetResult(instruction);
            return result;

        }

        public static IOperate GetOperationClass(string opCode)
        {
            //Get all classes that are implementing IOperate interface to enable adding new instructions without changing the code.
            //If this part was implemented with a loop, each time a new instruction is added it must be included here as well which is not desirable. (OCP)
            foreach (Type mytype in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                 .Where(mytype => mytype.GetInterfaces().Contains(typeof(IOperate))))
            {
                IOperate op = (IOperate)Activator.CreateInstance(mytype);
                string TypeOpcode = op.GetOpCode();

                if (opCode.Equals(TypeOpcode))
                {
                    return op;
                }

            }
            return null;
        }

        public static string GetOpCode(string instruction)
        {
            return instruction.Substring(0, 3);
        }
    }
}
