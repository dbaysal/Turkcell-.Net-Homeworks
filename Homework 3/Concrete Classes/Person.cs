using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Abstract_Classes
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SchoolNumber  { get; set; }
        public virtual void ComeToSchool()
        {
            Console.WriteLine("Person entered to the school");
        }
    }
}
