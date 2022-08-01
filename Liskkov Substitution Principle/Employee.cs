using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskkov_Substitution_Principle
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;
        
        public void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks here - other wise, this should be
            // a property set statement, not a method. 
            Manager = manager;
        }
    }
}
