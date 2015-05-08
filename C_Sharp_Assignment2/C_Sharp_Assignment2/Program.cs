using System;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                    System.Console.WriteLine("XOXOXOXO");
                else
                    System.Console.WriteLine("OXOXOXOX");
            }
            System.Console.WriteLine("Press any key to leave");
            System.Console.ReadLine();//parse
        }
    }
}