using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Students information default
            string firstName = "David";
            string lastName = "Lai";
            string birthday = "09/27/1993"; // (mm/dd/yyyy)
            string addressLine1 = "Somewhere";
            string addressLine2 = "Anywhere";
            string city = "Taichung";
            string state = "Taiwan";
            int postal_or_Zip = 80404;
            string country = "Taiwan";
            bool male = true;
            float height = 179.5f;
            float weight = 85.0f;

            //user interface
            int flag = 1;
            while (flag == 1 || flag == 2)
            {
                System.Console.WriteLine("Welcome, Enter '1' for showing Student Profile '2' for Change Student Profile '3' to leave");
                System.Console.Write("# ");
                string input = System.Console.ReadLine();
                flag = Convert.ToInt32(input);

                switch (flag)
                {
                    case 1:
                        System.Console.WriteLine("------------Student Profile-------------");
                        System.Console.Write("FirstName : " + firstName);
                        System.Console.Write(" LastName : " + lastName);
                        System.Console.WriteLine("Birthday : " + birthday);
                        System.Console.WriteLine("AddressLine1 : " + addressLine1);
                        System.Console.WriteLine("AddressLine2 : " + addressLine2);
                        System.Console.WriteLine("City : " + city);
                        System.Console.WriteLine("State : " + state);
                        System.Console.WriteLine("Postal_or_Zip : " + postal_or_Zip);
                        System.Console.WriteLine("Country : " + country);

                        if (male)
                        {
                            System.Console.WriteLine("Is Male");
                        }
                        else
                        {
                            System.Console.WriteLine("Is Female");
                        }

                        System.Console.WriteLine("Height : " + height);
                        System.Console.WriteLine("Weight : " + weight);
                        System.Console.WriteLine("Any Key to continue:");
                        System.Console.ReadLine(); // Parse
                        break;

                    case 2:
                        System.Console.WriteLine("------------Enter Student Profile-------------");
                        System.Console.Write("FirstName : ");
                        firstName = System.Console.ReadLine();
                        System.Console.Write("LastName : ");
                        lastName = System.Console.ReadLine();
                        System.Console.Write("Birthday (dd/mm/yyyy) : ");
                        birthday = System.Console.ReadLine();
                        System.Console.Write("AddressLine1 : ");
                        addressLine1 = System.Console.ReadLine();
                        System.Console.Write("AddressLine2 : ");
                        addressLine2 = System.Console.ReadLine();
                        System.Console.Write("City : ");
                        city = System.Console.ReadLine();
                        System.Console.Write("State : ");
                        state = System.Console.ReadLine();
                        System.Console.Write("Zip/Postal : ");
                        postal_or_Zip = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.Write("Country : ");
                        country = System.Console.ReadLine();

                        System.Console.Write("Is male (true/false) : ");
                        input = System.Console.ReadLine();
                        bool result = input.Equals("male", StringComparison.Ordinal);
                        if (result)
                        {
                            male = true;
                        }
                        else
                        {
                            male = false;
                        }

                        System.Console.Write("Height : ");
                        height = float.Parse(System.Console.ReadLine());
                        System.Console.Write("Weight : ");
                        weight = float.Parse(System.Console.ReadLine());

                        System.Console.WriteLine("Thanks for your input.");
                        break;

                    default:
                        break;

                }









            }




        }


    }


}
