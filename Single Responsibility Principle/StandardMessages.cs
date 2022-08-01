using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }
        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidatorError(string filedName)
        {
            Console.WriteLine($"You did not give us a valid {filedName}");
        }
    }
}
