using Graded_Homework_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Homework_1.Classes
{
    public class RegistrationOperations
    {
        public School ManagedSchool { get; set; }

        public RegistrationOperations(School school) => this.ManagedSchool = school;

        public void RegisterClass(string className)
        {
            Class newClass = new(className);
            this.ManagedSchool.Classes.Add(newClass);
        }

        public void RegisterStudent(string studentFirstName, string studentLastName)
        {
            StudentPerson newStudent = new(studentFirstName, studentLastName);
            this.ManagedSchool.Students.Add(newStudent);
        }

        public void RegisterTeacher(string teacherFirstName, string teacherLastName)
        {
            TeacherPerson newTeacher = new(teacherFirstName, teacherLastName);
            this.ManagedSchool.Teachers.Add(newTeacher);
        }
        public void RegisterToClass(Class c1, IAssignable assignable) => assignable.AssignToClass(c1);

    }
}
