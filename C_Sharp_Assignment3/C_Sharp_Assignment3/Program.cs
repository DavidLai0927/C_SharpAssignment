using System;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            /*try
            {
                    ValidatingStudentBirthday();
            }
            catch (NotImplementedException notImp)
            {
                    Console.WriteLine(notImp.Message);
            }*/
            Console.WriteLine("Choose Which to Enter ");
            Console.WriteLine("1.Student  2.Teacher  3.Course  4.program  5.degree  6.exit");
            int input = Int32.Parse(System.Console.ReadLine());
            switch (input)
            {
                case 1:
                    GetStudentInfo();
                    break;
                case 2:
                    GetTeacherInfo();
                    break;
                case 3:
                    GetCourseInfo();
                    break;
                case 4:
                    GetProgramInfo();
                    break;
                case 5:
                    GetDegreeInfo();
                    break;
                default:
                    return;
            }


        }

        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = System.Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = System.Console.ReadLine();
            Console.Write("Enter the student's Birthday (dd/mm/yyyy) : ");
            string birthday = System.Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthday);
            ValidatingStudentBirthday(birthday);

        }
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the Teacher's first name: ");
            string firstName = System.Console.ReadLine();
            Console.WriteLine("Enter the Teacher's last name");
            string lastName = System.Console.ReadLine();
            System.Console.Write("Enter the Teacher's Course : ");
            string Course = System.Console.ReadLine();

            PrintTeacherDetails(firstName, lastName, Course);

        }
        static void PrintTeacherDetails(string first, string last, string Course)
        {
            Console.WriteLine("{0} {1} is teaching : {2}", first, last, Course);
        }

        static void GetCourseInfo()
        {
            Console.WriteLine("Enter the Course's name: ");
            string name = System.Console.ReadLine();
            Console.WriteLine("Enter the Course's time: ");
            string time = System.Console.ReadLine();
            Console.WriteLine("Enter the Course's Teacher");
            string teacher = System.Console.ReadLine();

            PrintCourseDetails(name, time, teacher);
        }

        static void PrintCourseDetails(string name, string time, string teacher)
        {
            Console.WriteLine("Course name : {0} at {1} ,teacher : {2}", name, time, teacher);
        }

        static void GetProgramInfo()
        {
            Console.WriteLine("Enter the program's name : ");
            string name = System.Console.ReadLine();
            Console.WriteLine("Enter the program's objective : ");
            string objective = System.Console.ReadLine();
            Console.WriteLine("Enter the program's owner : ");
            string owner = System.Console.ReadLine();

            PrintCourseDetails(name, objective, owner);
        }

        static void PrintProgramDetails(string name, string objective, string owner)
        {
            Console.WriteLine("Program {0} aims to {1} ,owner : {2}", name, objective, owner);
        }

        static void GetDegreeInfo()
        {
            Console.WriteLine("Enter the 3 kinds of Degree's name : ");
            Console.WriteLine("#1 : ");
            string name1 = System.Console.ReadLine();
            Console.WriteLine("#2 : ");
            string name2 = System.Console.ReadLine();
            Console.WriteLine("#3 : ");
            string name3 = System.Console.ReadLine();


            PrintCourseDetails(name1, name2, name3);
        }

        static void PrintDegreeDetails(string name1, string name2, string name3)
        {
            Console.WriteLine("Three kinds of Degree {0} {1} and {2}", name1, name2, name3);
        }

        static void ValidatingStudentBirthday(string birthday)
        {
            //throw new NotImplementedException();
            string[] split = birthday.Split(new Char[] { ' ', ',', '.', ':', '\t', '/', '\\' });
            try
            {
                int day = Int32.Parse(split[0]);
                int month = Int32.Parse(split[1]);
                int year = Int32.Parse(split[2]);

                DateTime time = new DateTime(year, month, day);
                DateTime dt = DateTime.Now;
                if (dt.Year - year >= 18)
                {
                    Console.WriteLine("Student's birthday {0}/{1}/{2} is validated.", day, month, year);
                }
                else
                {
                    Console.WriteLine("Error: Student's isn't over 18");
                }
                //I don't consider month question, trouble some

            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return;
            }




        }


    }
}