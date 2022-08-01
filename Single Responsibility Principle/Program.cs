using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Single_Responsibility_Principle
{
    public class Program
    {
        static void Main(string[] args)
        {
            // nguyên tắc trách nhiệm duy nhất
            // mỗi lớp chỉ có một trách nhiệm duy nhất, và rằng trách nhiệm
            // đó nên được đóng gói hoàn toàn bởi lớp đó. Nó chỉ có 1
            // lý do duy nhất để thay đổi class
            StandardMessages.WelcomeMessage();

            // Ask for user information
            Person user = PersonDataCapture.Capture();

            // Check to be sure the first and last names are valid
            bool isUserValid =  PersonValidator.Validate(user);
            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Create a username for the person
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}