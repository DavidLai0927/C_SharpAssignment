using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment4
{
    class Program
    {
        public struct Student
        {
            public string firstName;
            public string lastName;
            public int id;
        }

        public struct Teacher
        {
            public string firstName;
            public string lastName;
            public int id;
        }

        public struct program
        {
            public string name;
            public string objective;
            public string owner;
        }

        public struct course
        {
            public string name;
            public string time;
            public string teacher;
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            //students[2].firstName = "Lai";
            //students[2].lastName = "David";
            //students[2].id = 12345678;

            Console.WriteLine("Write Student data below");
            for (int i = 0; i < students.Length; i++)
            {
                try
                {
                    Console.WriteLine("Student{0}", i);
                    Console.Write("FirstName : ");
                    students[i].firstName = Console.ReadLine();
                    Console.Write("LastName : ");
                    students[i].lastName = Console.ReadLine();
                    Console.Write("id (digits) : ");
                    students[i].id = Int32.Parse( Console.ReadLine() );
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student{0}", i);
                Console.WriteLine("FirstName : {0}", students[i].firstName);
                Console.WriteLine("LastName : {0}", students[i].lastName);
                Console.WriteLine("id : {0}", students[i].id);
                Console.WriteLine("");
            }

            //Console.WriteLine("student[2] firstName {0} , lastName {1} , id {2}", students[2].firstName, students[2].lastName, students[2].id);
            Console.ReadLine();//parse
            
        }
    }
}
