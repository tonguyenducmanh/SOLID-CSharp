using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion_principle
{
    public class Emailer : IMessageSender
    {
        public void SendMesage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
        }
    }
}
