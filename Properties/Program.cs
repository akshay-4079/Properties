using System;

namespace Properties
{
    class Program
    {
        public static void Main(string[] args)
        {
            changeCase change = new changeCase();
            Console.WriteLine("C Properties");
            Console.WriteLine("Enter A Sentence");
            change.Sentence = Console.ReadLine();
            Console.WriteLine("The Output Displayed");
            Console.WriteLine(change.Sentence);
            Console.WriteLine("Properties can also be used to display output in a specific way");
            changeCase change2 = new changeCase2();
            Console.WriteLine("Enter A Sentence");
            change2.Sentence = Console.ReadLine();
            Console.WriteLine($"The Sentence in Upper Case is {change2.Sentence}");

        
        }
    }
}
