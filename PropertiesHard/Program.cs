using System;

namespace PropertiesHard
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Properties can be used to compute certain values");
            Compute c = new Compute();
            NewMethod(c);
            Console.WriteLine("You can save the property such that joining take place only on any update");
            Compute2 d = new Compute2();
            NewMethod(d);

        }

        private static void NewMethod(Compute c)
        {

            Console.WriteLine("Enter First Name");
            c.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            c.LastName = Console.ReadLine();
            Console.WriteLine($"Full name is {c.FullName}");
            Console.WriteLine($"Full name is {c.FullName}");
            Console.WriteLine("Enter Last Name");
            c.LastName = Console.ReadLine();
            Console.WriteLine($"Full name is {c.FullName}");
        }
    }
}
