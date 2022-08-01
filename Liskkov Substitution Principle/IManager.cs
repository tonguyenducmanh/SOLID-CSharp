using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskkov_Substitution_Principle
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
