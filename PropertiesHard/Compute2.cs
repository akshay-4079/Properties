using System;
namespace PropertiesHard
{
    public class Compute2:Compute
    {
        public override string FirstName { get { return firstName; } set { firstName = (!string.IsNullOrEmpty(value)) ? value: throw new Exception("Empty fiekd");  fullName=null;  } }
        public override string LastName { get { return lastName; } set { lastName = (!string.IsNullOrEmpty(value)) ? value : throw new Exception("Empty fiekd");fullName = null; } }
        public override string FullName
        {
            get
            {
                if (fullName == null) { Console.WriteLine("I am Joining the Name"); fullName= $"{FirstName}  {LastName}"; return fullName ; }
                else { Console.WriteLine("I am Retrieving Name"); return fullName; }
            }
        }

        private string firstName;
        private string lastName;
        private string fullName;

    }
}
