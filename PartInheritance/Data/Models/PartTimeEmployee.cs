using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartInheritance.Data.Models
{
    internal class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate {  get; set; }
    }
}
