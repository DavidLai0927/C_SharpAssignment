using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment5
{
    public class Student
    {
        public Student(string fN, string lN)
        {
            this.firstName = fN;
            this.lastName = lN;
        }
        public string firstName { get; set;}
        public string lastName { get; set; }
        public string birthday { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int postal_or_Zip { get; set; }
        public string country { get; set; }
        public bool male { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
    }

    public class Teacher
    {
        public Teacher(string fN, string lN)
        {
            this.firstName = fN;
            this.lastName = lN;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }
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
        public Student [] students = new Student[3];
        public Teacher[] teachers = new Teacher[3];
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Amy", "AAA");
            Student student2 = new Student("Bob", "BBB");
            Student student3 = new Student("Cindy", "CCC");
            Course cource = new Course();
            cource.name = "Programming with C#";
            cource.students[0] = student1;
            cource.students[1] = student2;
            cource.students[2] = student3;
            Teacher teacher1 = new Teacher("David","DDD");
            cource.teachers[0] = teacher1;
            Degree degree = new Degree("Bachelor");
            UProgram uprogram = new UProgram("Information Technology");

            Console.WriteLine("The {0} programs contains the {1} degree", uprogram.name, degree.deg);
            Console.WriteLine("The {0} degree contains the course {1}", degree.deg, cource.name);
            Console.WriteLine("The {0} course contains {1} student(s)", cource.name, cource.students.Length);
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadLine();
        }
    }
}
