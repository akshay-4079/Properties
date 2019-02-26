using System;
using Properties;
namespace PropertiesMedium
{
    public class Validation : changeCase
    {
        public  string Sentence1 { get => _string; set => _string = (!string.IsNullOrEmpty(value)) ? Message : throw new Exception("Dont Enter an Empty String"); }
        private string Message = "Please Follow the Instructions";
        public string protectedName
        {
            get
            {
               return _string1;
            }private set
            {
              _string1=  (!string.IsNullOrEmpty(value)) ? value : throw new ArgumentException();
            }
        }
     public void ChangeProtected()
        {
            Console.WriteLine("I am Changing the Protected Name");
            _string1 = Sentence;

        }
        private string _string1 = "Akshay";
    }


    }

