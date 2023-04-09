using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graded_Homework_1.Interfaces;

namespace Graded_Homework_1.Classes
{
    public class TeacherPerson : Person, IAssignable
    {
        public static int TeacherCount = 0;

        public TeacherPerson(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = TeacherCount++;
        }

        public void AssignToClass(Class c)
        {
            c.Teacher = this;
        }

        public override string ToString()
        {
            return $"{this.Id} - {this.FirstName} {this.LastName}";
        }
    }
}
