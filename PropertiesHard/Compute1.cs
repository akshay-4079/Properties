using System;
using Properties;
namespace PropertiesHard
{
    public class Compute
    {
        public virtual string FirstName { get { return _string; }  set { _string = (!string.IsNullOrEmpty(value)) ? value : throw new Exception("Empty fiekd"); } }
        public virtual string LastName { get { return _string1; }  set { _string1 = (!string.IsNullOrEmpty(value)) ? value : throw new Exception("Empty fiekd"); } }
        public virtual string FullName{ get { Console.WriteLine("Joining the Names"); return $"{FirstName}  {LastName}"; } }
        private string _string;
        private string _string1;

    }


}
