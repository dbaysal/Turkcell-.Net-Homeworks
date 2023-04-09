using Graded_Homework_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Homework_1.Classes
{
    public class SchoolManagement
    {
        public RegistrationOperations Registration { get; set; }
        public DataAccessOperations DataAccess { get; set; }
        public ClassOperations ClassOperations { get; set; }

        public SchoolManagement(RegistrationOperations registration, DataAccessOperations dataAccess, ClassOperations classOperations)
        {
            this.Registration = registration;
            this.DataAccess = dataAccess;
            this.ClassOperations = classOperations;
        }

        public void RegisterClass(string className) => this.Registration.RegisterClass(className);

        public void RegisterStudent(string studentFirstName, string studentLastName) => this.Registration.RegisterStudent(studentFirstName, studentLastName);
       
        public void RegisterTeacher(string teacherFirstName, string teacherLastName) => this.Registration.RegisterTeacher(teacherFirstName, teacherLastName);
        
        public void RegisterToClass(Class selectedClass, IAssignable assignable) => this.Registration.RegisterToClass(selectedClass, assignable);

        public StudentPerson SearchStudentInClassByFullName(int classId, string studentName) => this.DataAccess.SearchStudentInClassByFullName(classId, studentName);

        public StudentPerson SearchStudentInClassById(int classId, int studentId) => this.DataAccess.SearchStudentInClassById(classId, studentId);

        public Class GetClass(int classId) => this.DataAccess.GetClass(classId);

        public TeacherPerson GetTeacherPerson(int teacherId) => this.DataAccess.GetTeacherPerson(teacherId);

        public StudentPerson GetStudentPerson(int studentId) => this.DataAccess.GetStudentPerson(studentId);

        public void PrintAllClasses() => this.DataAccess.PrintAllClasses();

        public void PrintAllStudents() => this.DataAccess.PrintAllStudents();

        public void PrintAllTeachers() => this.DataAccess.PrintAllTeachers();

        public void PrintClassesWithTeachers() => this.DataAccess.PrintClassesWithTeachers();

        public void PrintClassWithTeacherAndStudents(int classId) => this.DataAccess.PrintClassWithTeacherAndStudents(classId);
        public void SendHomeworkToTeacher(int studentId, int classId) => this.ClassOperations.SendHomeworkToTeacher(studentId, classId);



    }
}
