using System;
namespace Properties
{
    public class changeCase
    {
        public virtual string  Sentence
        {
            get
            {
                return _string;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    { _string = value;
                }

            }


        }
        protected string _string;

    }
}
