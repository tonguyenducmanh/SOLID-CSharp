using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskkov_Substitution_Principle
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
        public void FireSomeone()
        {
            // Simulate fire someone
            Console.WriteLine("You're fired!");
        }
    }
}
