using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Homework_1.Classes
{
    public class School
    {
        public List<Class> Classes { get; set; }
        public List<TeacherPerson> Teachers { get; set; }
        public List<StudentPerson> Students { get; set; }

        public School()
        {
            Classes = new List<Class>();
            Teachers = new List<TeacherPerson>();
            Students = new List<StudentPerson>();
        }
    }
}
