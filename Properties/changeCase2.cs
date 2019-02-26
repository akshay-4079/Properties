using System;
namespace Properties
{
    public class changeCase2:changeCase
    {

        public override string Sentence
        {
            get

            {
             
                return _string.ToUpper();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _string = value;
                }
            }
        }

    }
}
