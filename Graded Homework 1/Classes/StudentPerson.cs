using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graded_Homework_1.Interfaces;

namespace Graded_Homework_1.Classes
{
    public class StudentPerson : Person, IAssignable
    {
        public static int StudentId = 0;

        public StudentPerson(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = StudentId++;
        }

        public void AssignToClass(Class c)
        {
            c.Students.Add(this);
        }

        public override string ToString()
        {
            return $"{this.Id} - {this.FirstName} {this.LastName}";
        }
    }
}
