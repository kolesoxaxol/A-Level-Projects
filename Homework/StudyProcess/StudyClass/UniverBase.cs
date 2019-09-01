using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyClass
{
    public static class UniverBase
    {

        private static List<Teacher> _Teachers;
        private static List<Student> _Students;
        private static List<Group> _Groups;
        private static List<Group> _WholeGroup;

        static UniverBase()
        {
            _Teachers = new List<Teacher>();
            _Students = new List<Student>();
            _Groups = new List<Group>();
            _WholeGroup = new List<Group>();
        }

        public static int GetTeachersCount()
        {
            return _Teachers.Count;
        }

        public static int GetStudentsCount()
        {
            return _Students.Count;
        }

        public static int GetGoupsCount()
        {
            return _Groups.Count;
        }

        public static void AddTeacher(Teacher teacher)
        {
            _Teachers.Add(teacher);
        }

        public static void AddStudent(Student student)
        {
            _Students.Add(student);
        }

        public static void AddGroup(Group group)
        {
            _Groups.Add(group);
        }

        public static Teacher[] GetTeachers
        {
            get { return _Teachers.ToArray(); }
        }

        public static List<Student> GetStudents
        {
            get { return _Students; }
        }

        public static Group[] GetGroups
        {
            get { return _Groups.ToArray(); }
        }

        public static void AddWholeGroup(Group group)
        {
            _WholeGroup.Add(group);
        }

        public static Group[] GetWholeGroups
        {
            get { return _WholeGroup.ToArray(); }
        }
    }
}
