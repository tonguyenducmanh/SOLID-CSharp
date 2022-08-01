using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion_principle
{
    public class Chore : IChore
    {
        ILogger _logger;
        IMessageSender _messageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }
        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }
        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Complete {ChoreName}");
            _messageSender.SendMesage(Owner, $"The chore {ChoreName} is complete");
        }
    }
}
