using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using StudyClass;

namespace StudyProcess_Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo pressedKey;

            Console.WriteLine("Создание базы студентов...");
            Console.WriteLine("");

            string[] teachers = File.ReadAllLines("Teachers.txt");
            string[] students = File.ReadAllLines("Students.txt");
            string[] groups = File.ReadAllLines("Groups.txt");

            foreach (string teacherStr in teachers)
            {
                string teacherName = teacherStr.Split(':')[0];
                string teacherType = teacherStr.Split(':')[1];

                Teacher teacher = new Teacher();
                    teacher.TeacherName = teacherName;
                    teacher.TeacherType = teacherType;
                UniverBase.AddTeacher(teacher);
            }

            foreach (string studentsStr in students)
            {
                Student student = new Student();
                    student.StudentName = studentsStr;
                UniverBase.AddStudent(student);
            }

            foreach (string groupStr in groups)
            {
                Group group = new Group();
                    group.GroupName = groupStr;
                UniverBase.AddGroup(group);
            }

            Console.WriteLine($"В базе преподователей: {UniverBase.GetTeachersCount()}");
            Console.WriteLine($"В базе студентов: {UniverBase.GetStudentsCount()}");
            Console.WriteLine($"Создано групп: {UniverBase.GetGoupsCount()}");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Декану необходимо распределить учащихся по группам, а группам назначить преподователей.");
            Console.WriteLine("Нажмите \"Y\", чтобы позвать декана, нажмите \"N\", чтобы его не звать и оставить всё как есть.");
            pressedKey = Console.ReadKey(true);

            switch (pressedKey.Key.ToString())
            {
                case "Y":
                    Dean.SortUniver();

                    var wholeGroup = UniverBase.GetWholeGroups;

                    Console.WriteLine("Нажмите \"Y\", чтобы посмотреть что сделал декан или \"N\", чтобы оставить всё как есть.");
                    pressedKey = Console.ReadKey(true);

                    switch (pressedKey.Key.ToString())
                    {
                        case "Y":
                            foreach (Group group in wholeGroup)
                            {
                                string[] studentName = group.GetStudents();
                                foreach (string student in studentName)
                                {
                                    Console.WriteLine($"Группа: {group.GroupName}, преподователь: {group.TeacherName}, Студент: {student}");
                                }
                            }
                            break;

                        case "N":
                            break;

                        default:
                            break;
                    }
                    break;

                case "N":
                    break;

                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
