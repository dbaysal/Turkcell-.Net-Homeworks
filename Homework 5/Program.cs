using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static IOperate Decoder(string instruction)
        {
            string OpCode = GetOpCode(instruction);
            IOperate? operationClass = GetOperationClass(OpCode);

            

        }

        private static IOperate GetOperationClass(string opCode)
        {
            //Get all classes that are implementing IOperate interface to enable adding new instructions without changing the code
            foreach (Type mytype in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                 .Where(mytype => mytype.GetInterfaces().Contains(typeof(IOperate))))
            {
                IOperate op = (IOperate)mytype;
                string TypeOpcode = op.GetOpCode();

                if (opCode.Equals(TypeOpcode))
                {
                    return (IOperate)Activator.CreateInstance(mytype);
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
