using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Homework_1.Classes
{
    public class Class
    {
        public static int ClassId = 0;
        public int Id { get; set; }
        public string ClassName { get; set; }
        public TeacherPerson? Teacher { get; set; }
        public List<StudentPerson> Students { get; set; }

        public Class(string className)
        {
            this.Id = ClassId++;
            this.ClassName = className;
            this.Students = new List<StudentPerson>();
        }

        public void PrintStudentList()
        {
            if (this.Students.Count > 0)
            {
                Console.WriteLine("Öğrenciler : ");
                this.Students.ForEach(student => Console.WriteLine(student));
            }
            else
            {
                Console.WriteLine("Sınıfta öğrenci bulunmamakta.");
            }
        } 

        public void PrintTeacher() => Console.WriteLine(this.Teacher == null ? "Bu sınıfa bir öğretmen atanmamış" : "Öğretmen : " + this.Teacher);

        public void PrintClassWithTeacher() => Console.WriteLine($"{this.Id} - {this.ClassName} - " + 
                                                                 ((this.Teacher == null) ? "Sınıfa öğretmen atanmamış" 
                                                                     : $"{this.Teacher.FirstName} {this.Teacher.LastName}" ));

        public override string ToString() => $"{this.Id} - {this.ClassName}";

    }
}
