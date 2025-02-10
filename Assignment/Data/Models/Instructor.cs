using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double Hour_Rate { get; set; }
        public ICollection<Course_Ins> Instructors { get; set; } = new List<Course_Ins>();
        #region Work[One]
        [ForeignKey(nameof(Department))]
        public int Dept_id { get; set; }
        [InverseProperty(nameof(Models.Department.Instructors))]
        public Department? Departmentt { get; set; }
        #endregion
        #region Works[One]
        [InverseProperty(nameof(Models.Department.Instruct))]
        public Department? Exist { get; set; }
        #endregion
    }
}
