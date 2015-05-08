using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Assignment6
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool male { get; set; }
    }

    public class Student : Person
    {
        public Stack<int> score = new Stack<int>();
        public void TakeTest()
        {
            Console.WriteLine("Student {0} takes test.", lastName);
        }
    }

    public class Teacher : Person
    {
        public void GradeTest()
        {
            Console.WriteLine("Teacher {0} grade test.", lastName);
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
        public ArrayList students = new ArrayList();
        public Teacher[] teachers = new Teacher[3];
    }

    public class myComparerClass : IComparer
    {
        int IComparer.Compare(Object x, Object y)
        {
            Student a = (Student)x; Student b = (Student)y;
            return ((new CaseInsensitiveComparer()).Compare(a.firstName, b.firstName));
        }
    }

    

    class Program
    {
        static void ListStudents(Course cource)
        {
            foreach (Student sd in cource.students)
            {
                Console.WriteLine("First Name: {0} , Last Name: {1}" , sd.firstName, sd.lastName);
            }
            
        }

        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            student1.lastName = "John"; student1.firstName = "Lee";
            student2.lastName = "David"; student2.firstName = "Wang";
            student3.lastName = "Rebecca"; student3.firstName = "Lai";
            student1.score.Push(60); student1.score.Push(70); student1.score.Push(80); student1.score.Push(90); student1.score.Push(100);
            student2.score.Push(100); student2.score.Push(10); student2.score.Push(10); student2.score.Push(100); student2.score.Push(100);
            student3.score.Push(60); student3.score.Push(50); student3.score.Push(40); student3.score.Push(30); student3.score.Push(20);
            Course cource = new Course();
            cource.name = "Programming with C#";
            cource.students.Add(student1);
            cource.students.Add(student2);
            cource.students.Add(student3);
            ListStudents(cource);
            Console.WriteLine();
            //challenge below
            IComparer myComparer = new myComparerClass();
            cource.students.Sort(myComparer);
            ListStudents(cource);
            Console.WriteLine();
            //bonus challenfe below
            Stack<int> tmp = new Stack<int>();
            tmp.Push(student1.score.Pop());
            tmp.Push(student1.score.Pop());
            student1.score.Peek();
            student1.score.Push(tmp.Pop());
            student1.score.Push(tmp.Pop());
            foreach (Student sd in cource.students)
            {
                Console.Write("First Name: {0} , Last Name: {1} Grade : ", sd.firstName, sd.lastName);
                while (sd.score.Count != 0)
                {
                    Console.Write("{0} ", sd.score.Peek()); 
                    tmp.Push(sd.score.Pop());
                }
                while (tmp.Count != 0)
                {
                    sd.score.Push(tmp.Pop());
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    
}
