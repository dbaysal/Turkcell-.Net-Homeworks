using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Abstract_Classes
{
    public abstract class EngineeringStudent
    {
        public List<string> LabCourses { get; set; }
        public abstract void DoComputation();
    }
}
