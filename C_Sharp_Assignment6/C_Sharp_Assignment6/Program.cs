using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment6
{
    public class Person
    {
        public string name { get; set; }
        public bool male { get; set; }
    }

    public class Student : Person
    {
        public void TakeTest()
        {
            Console.WriteLine("Student {0} takes test.", name);
        }
    }

    public class Teacher : Person
    {
        public void GradeTest()
        {
            Console.WriteLine("Teacher {0} grade test.", name);
        }
    }




    public class UProgram
    {
        public UProgram(string n)
        {
            this.name = n;
        }
        public string name { get; set; }
        public string objective { get; set; }
        public string owner { get; set; }
        public Degree degree { get; set; }
    }

    public class Degree
    {
        public Degree(string n)
        {
            this.deg = n;
        }
        public string deg;
        public Course course { get; set; }
    }

    public class Course
    {
        public string name { get; set; }
        //public string teacher { get; set; }
        public string time { get; set; }
        public Student[] students = new Student[3];
        public Teacher[] teachers = new Teacher[3];
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Course cource = new Course();
            cource.name = "Programming with C#";
            cource.students[0] = student1;
            cource.students[1] = student2;
            cource.students[2] = student3;
            Teacher teacher1 = new Teacher();
            cource.teachers[0] = teacher1;
            Degree degree = new Degree("Bachelor");
            UProgram uprogram = new UProgram("Information Technology");

            Console.WriteLine("The {0} programs contains the {1} degree", uprogram.name, degree.deg);
            Console.WriteLine("The {0} degree contains the course {1}", degree.deg, cource.name);
            Console.WriteLine("The {0} course contains {1} student(s)", cource.name, cource.students.Length);
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadLine();


            //Challenge behind
            Person person = new Person();
            Student student = new Student();
            person = student;
            student = (Student)person;
            person.name = "a man";
        }
    }
}
