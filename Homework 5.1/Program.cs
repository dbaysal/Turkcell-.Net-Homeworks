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
            string instruction = "00000100001";
            int result = Decoder.Decode(instruction);
            Console.WriteLine($"Intruction : {instruction}");
            Console.WriteLine($"Result : {result}");
        }

        
    }
}
