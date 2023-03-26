using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    /// <summary>
    /// IOperate interface will allow developers to further extend the
    /// available instructions for example, if someone wanted to add multiplication
    /// instruction, rather than changing most of the code only adding a new class
    /// and implementing IOperate methods will be enough. (OCP)
    /// </summary>
    public interface IOperate
    {
        int GetResult(string instruction);
        string GetOpCode();
    }
}
