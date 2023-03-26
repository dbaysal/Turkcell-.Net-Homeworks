using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    public interface IOperate
    {
        string GetResult();
        string GetOpCode();
    }
    

    public class Add : IOperate
    {
        public string GetResult()
        {
            throw new NotImplementedException();
        }
        public string GetOpCode()
        {
            return "000";
        }

        public int Addition(int x, int y)
        {
            return x + y;
        }

    }

    public class Subtract : IOperate
    {
        public string GetOpCode()
        {
            return "001";
        }


        public string GetResult()
        {
            throw new NotImplementedException();
        }

        public int Subtraction(int x, int y)
        {
            return x - y;
        }

        
    }

}
