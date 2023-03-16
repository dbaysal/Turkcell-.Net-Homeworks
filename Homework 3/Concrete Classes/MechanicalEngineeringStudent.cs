using Homework_3.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Concrete_Classes
{
    public class MechanicalEngineeringStudent : EngineeringStudent
    {
        public override void DoComputation()
        {
            Console.WriteLine("Mechanical engineering students prefer to use paper and pencil for computations.");
        }
    }
}
