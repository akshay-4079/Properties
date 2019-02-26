using System;
using Properties;


namespace PropertiesMedium
{
    class Program
    {
    static void Main(string[] args)
        {
            Validation valid = new Validation();
          Console.WriteLine("Properties can also be used for validation");
            try
            {
                Console.WriteLine("Try to Enter an Empty Value");
                valid.Sentence1 = Console.ReadLine();
                Console.WriteLine(valid.Sentence);
            }
            catch(Exception)
            {
                Console.WriteLine("Dont Enter an Empty Line");
            }
            Console.WriteLine($"Protected String {valid.protectedName}");
            Console.WriteLine("Properties can also be used to protect some values try to change the protected string");
            // valid.protectedName=Console.ReadLine();
            // This statement cant be run since it is set to read only
            valid.Sentence = Console.ReadLine();
            valid.ChangeProtected();
            Console.WriteLine($"Changed {valid.protectedName}");

        }
    }
}
