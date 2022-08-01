using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion_principle
{
    public class Texter : IMessageSender
    {
        public void SendMesage(IPerson person, string message)
        {
            Console.WriteLine($"I am texting to {person.FirstName} : {message}");
        }
    }
}
