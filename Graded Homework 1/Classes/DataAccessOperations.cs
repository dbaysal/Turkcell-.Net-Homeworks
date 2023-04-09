using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Homework_1.Classes
{
    public class DataAccessOperations
    {
        public School ManagedSchool { get; set; }

        public DataAccessOperations(School school) => this.ManagedSchool = school;

        public StudentPerson SearchStudentInClassByFullName(int classId, string studentName)
        {
            Class? selectedClass = GetClass(classId);
            StudentPerson? selectedStudent = selectedClass.Students.Find(student =>
                (student.FirstName + " " + student.LastName).Equals(studentName));
            if (selectedStudent == null)
            {
                throw new Exception($"{selectedClass.ClassName} sınıfında {studentName} isimde bir öğrenci bulunamadı");
            }

            return selectedStudent;
        }

        public StudentPerson SearchStudentInClassById(int classId, int studentId)
        {
            Class? selectedClass = GetClass(classId);
            StudentPerson? selectedStudent = selectedClass.Students.Find(student =>
                (student.Id == studentId));
            if (selectedStudent == null)
            {
                throw new Exception($"{selectedClass.ClassName} sınıfında {studentId} Id'sine sahip bir öğrenci bulunamadı");
            }

            return selectedStudent;
        }

        public Class GetClass(int classId)
        {
            Class? selectedClass = this.ManagedSchool.Classes.Find(c => c.Id == classId);
            if (selectedClass == null)
            {
                throw new Exception($"{classId} Id'sine sahip bir sınıf bulunamadı");
            }
            return selectedClass;
        }

        public TeacherPerson GetTeacherOfClass(int classId)
        {
            Class? selectedClass = this.GetClass(classId);
            if (selectedClass.Teacher != null)
            {
                return selectedClass.Teacher;
            }
            else
            {
                throw new Exception("Seçilen sınıfın öğretmeni bulunmamakta");
            }
        }

        public TeacherPerson GetTeacherPerson(int teacherId)
        {
            TeacherPerson? selectedTeacher = this.ManagedSchool.Teachers.Find(t => t.Id == teacherId);
            if (selectedTeacher == null)
            {
                throw new ArgumentNullException($"{teacherId} Id'sine sahip bir öğretmen bulunamadı");
            }
            return selectedTeacher;
        }

        public StudentPerson GetStudentPerson(int studentId)
        {
            StudentPerson? selectedStudent = this.ManagedSchool.Students.Find(s => s.Id == studentId);
            if (selectedStudent == null)
            {
                throw new Exception($"{studentId} Id'sine sahip bir öğrenci bulunamadı");
            }
            return selectedStudent;
        }

        public void PrintAllClasses()
        {
            if (this.ManagedSchool.Classes.Count > 0)
            {
                this.ManagedSchool.Classes.ForEach(c => Console.WriteLine(c));
            }
            else
            {
                Console.WriteLine("Okulda sınıf bulunmamakta");
            }
            
        }

        public void PrintAllStudents()
        {
            if (this.ManagedSchool.Students.Count > 0)
            {
                this.ManagedSchool.Students.ForEach(s => Console.WriteLine(s));
            }
            else
            {
                Console.WriteLine("Okulda öğrenci bulunmamakta");
            }
        }

        public void PrintAllTeachers()
        {
            if (this.ManagedSchool.Teachers.Count > 0)
            {
                this.ManagedSchool.Teachers.ForEach(t => Console.WriteLine(t));
            }
            else
            {
                Console.WriteLine("Okulda öğretmen bulunmamakta");
            }
        }

        public void PrintClassesWithTeachers()
        {
            if (this.ManagedSchool.Classes.Count > 0)
            {
                this.ManagedSchool.Classes.ForEach(c => c.PrintClassWithTeacher());
            }
            else
            {
                Console.WriteLine("Okulda sınıf bulunmamakta");
            }
        } 

        public void PrintClassWithTeacherAndStudents(int classId)
        {
            Class? selectedClass = this.GetClass(classId);
            selectedClass.PrintTeacher();
            selectedClass.PrintStudentList();
        }

        public bool CheckIfStudentInClass(int studentId, int classId)
        {
            Class? selectedClass = this.GetClass(classId);
            StudentPerson? selectedStudent = this.GetStudentPerson(studentId);
            return selectedClass.Students.Find(s => s.Id == studentId) != null;
        }

    }
}
