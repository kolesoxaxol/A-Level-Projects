using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StudyClass
{
    public class Group
    {
        private List<string> studentsGroup = new List<string>();
        public string GroupName { get; set; }
        public string TeacherName { get; set; }
        public string TeacherType { get; set; }

        public void AddStudentToGroup(Student newStudent)
        {
            studentsGroup.Add(newStudent.StudentName);
        }

        public int GetCountStudents()
        {
            return studentsGroup.Count;
        }

        public string[] GetStudents()
        {
            return studentsGroup.ToArray();
        }
    }
}
