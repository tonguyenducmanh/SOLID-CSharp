using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidatorError("first name");
                return false;
            }
            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidatorError("last name");
                return false;
            }
            return true;
        }
    }
}
