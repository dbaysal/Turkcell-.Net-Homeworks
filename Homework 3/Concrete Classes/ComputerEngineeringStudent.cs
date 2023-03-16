using Homework_3.Abstract_Classes;
using Homework_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Concrete_Classes
{
    public class ComputerEngineeringStudent : EngineeringStudent, ICanCode
    {
        public void Code()
        {
            Console.WriteLine("Computer engineering student is coding...");
        }

        public override void DoComputation()
        {
            Console.WriteLine("Computer engineering students prefer to use computer for computations.");
        }
    }
}
