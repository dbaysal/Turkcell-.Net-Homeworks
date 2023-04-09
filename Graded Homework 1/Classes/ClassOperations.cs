using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Homework_1.Classes
{
    public class ClassOperations
    {
        public DataAccessOperations DataAccess { get; set; }
        public ClassOperations(DataAccessOperations dataAccess)
        {
            this.DataAccess = dataAccess;
        }

        public void SendHomeworkToTeacher(int studentId, int classId)
        {
            bool isStudentInClass = this.DataAccess.CheckIfStudentInClass(studentId, classId);
            if (isStudentInClass)
            {
                TeacherPerson selectedTeacher = this.DataAccess.GetTeacherOfClass(classId);
                StudentPerson? selectedStudent = this.DataAccess.GetStudentPerson(studentId);
                Console.WriteLine($"{selectedStudent.FirstName} {selectedStudent.LastName} öğrencisi" +
                                  $" {selectedTeacher.FirstName} {selectedTeacher.LastName}" +
                                  $" öğretmenine ödevini gönderdi");
            }
            else
            {
                throw new Exception("Belirtilen öğrenci sınıfta bulunamadı");
            }

        }

    }
}
