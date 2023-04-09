using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Homework_1.Classes
{
    public class Menu
    {
        public SchoolManagement SchoolManagement { get; set; }

        public Menu(SchoolManagement schoolManagement)
        {
            this.SchoolManagement = schoolManagement;
        }
        public void DisplayMenu()
        {
            Console.WriteLine("\n\n-----------------OKUL YÖNETİM SİSTEMİ-----------------");
            Console.WriteLine();
            Console.WriteLine("Ekleme Operasyonları : ");
            Console.WriteLine("1 - Okula Sınıf Ekle");
            Console.WriteLine("2 - Okula Öğrenci Ekle");
            Console.WriteLine("3 - Okula Öğretmen Ekle");
            Console.WriteLine("4 - Sınıfa Öğretmen Ekle");
            Console.WriteLine("5 - Sınıfa Öğrenci Ekle");
            Console.WriteLine();
            Console.WriteLine("Yazdırma Operasyonları : ");
            Console.WriteLine("6 - Okuldaki Bütün Sınıfları Yazdır");
            Console.WriteLine("7 - Okuldaki Bütün Öğrencileri Yazdır");
            Console.WriteLine("8 - Okuldaki Bütün Öğretmenleri Yazdır");
            Console.WriteLine("9 - Okuldaki Bütün Sınıfları Öğretmenleri ile Yazdır");
            Console.WriteLine("10 - Bir Sınıfın Öğrencilerini ve Öğretmenini Yazdır");
            Console.WriteLine();
            Console.WriteLine("Arama Operasyonları : ");
            Console.WriteLine("11 - Sınıfta Tam İsim ile Öğrenci Ara");
            Console.WriteLine("12 - Sınıfta Id ile Öğrenci Ara");
            Console.WriteLine();
            Console.WriteLine("Sınıf Etkileşim Operasyonları : ");
            Console.WriteLine("13 - Sınıf Öğretmenine Ödev Gönderme");
            Console.WriteLine();
            Console.WriteLine("Çıkış İçin -1 Girin\n\n");

        }

        public void ExecuteSelection(int selection)
        {
            string className, studentFirstName, studentLastName, studentFullName, teacherFirstName, teacherLastName;
            int teacherId, studentId, classId;
            StudentPerson selectedStudent;
            TeacherPerson selectedTeacher;
            Class selectedClass;

            switch (selection)
            {
                case 1:
                    Console.WriteLine("Lütfen sınıf ismi girin : ");
                    className = Console.ReadLine();
                    this.SchoolManagement.RegisterClass(className);
                    break;
                case 2:
                    Console.WriteLine("Lütfen öğrenci adı girin");
                    studentFirstName = Console.ReadLine();
                    Console.WriteLine("Lütfen öğrenci soyismi girin");
                    studentLastName = Console.ReadLine();
                    this.SchoolManagement.RegisterStudent(studentFirstName, studentLastName);
                    break;
                case 3:
                    Console.WriteLine("Lütfen öğretmen adı girin");
                    teacherFirstName = Console.ReadLine();
                    Console.WriteLine("Lütfen öğretmen soyismi girin");
                    teacherLastName = Console.ReadLine();
                    this.SchoolManagement.RegisterTeacher(teacherFirstName, teacherLastName);
                    break;
                case 4:
                    Console.WriteLine("Lütfen öğretmen Id'si girin");
                    teacherId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen sınıf Id'si girin");
                    classId = Convert.ToInt32(Console.ReadLine());
                    selectedTeacher = this.SchoolManagement.GetTeacherPerson(teacherId);
                    selectedClass = this.SchoolManagement.GetClass(classId);
                    this.SchoolManagement.RegisterToClass(selectedClass, selectedTeacher);
                    break;
                case 5:
                    Console.WriteLine("Lütfen öğrenci Id'si girin");
                    studentId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen sınıf Id'si girin");
                    classId = Convert.ToInt32(Console.ReadLine());
                    selectedStudent = this.SchoolManagement.GetStudentPerson(studentId);
                    selectedClass = this.SchoolManagement.GetClass(classId);
                    this.SchoolManagement.RegisterToClass(selectedClass, selectedStudent);
                    break;
                case 6:
                    this.SchoolManagement.PrintAllClasses();
                    break;
                case 7:
                    this.SchoolManagement.PrintAllStudents();
                    break;
                case 8:
                    this.SchoolManagement.PrintAllTeachers();
                    break;
                case 9:
                    this.SchoolManagement.PrintClassesWithTeachers();
                    break;
                case 10:
                    Console.WriteLine("Lütfen sınıf Id'si girin");
                    classId = Convert.ToInt32(Console.ReadLine());
                    this.SchoolManagement.PrintClassWithTeacherAndStudents(classId);
                    break;
                case 11:
                    Console.WriteLine("Lütfen sınıf Id'si girin");
                    classId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen öğrencinin tam ismini girin");
                    studentFullName = Console.ReadLine();
                    selectedStudent = this.SchoolManagement.SearchStudentInClassByFullName(classId, studentFullName);
                    Console.WriteLine(selectedStudent);
                    break;
                case 12:
                    Console.WriteLine("Lütfen sınıf Id'si girin");
                    classId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen öğrencinin Id'sini girin");
                    studentId = Convert.ToInt32(Console.ReadLine());
                    selectedStudent = this.SchoolManagement.SearchStudentInClassById(classId, studentId);
                    Console.WriteLine(selectedStudent);
                    break;
                case 13:
                    Console.WriteLine("Lütfen sınıf Id'si girin");
                    classId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lütfen öğrencinin Id'sini girin");
                    studentId = Convert.ToInt32(Console.ReadLine());
                    this.SchoolManagement.SendHomeworkToTeacher(studentId, classId);
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir seçenek girin");
                    break;

            }
        }


    }
}
