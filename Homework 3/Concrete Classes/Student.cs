using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Abstract_Classes
{
    public class Student : Person
    {
        public List<string> Classes { get; set; }
        public double CGPA { get; set; }
        public override void ComeToSchool()
        {
            base.ComeToSchool();
            //Students enter the class after coming to the school
            Console.WriteLine("Student entered the class");
        }
    }
}
