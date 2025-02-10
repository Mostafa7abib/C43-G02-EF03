using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(25, 60)]
        public int Age { get; set; }
        public ICollection<Std_Courses> Courses { get; set; } = new HashSet<Std_Courses>();
        #region Included[One]
        [ForeignKey(nameof(Department))]
        public int Dep_id { get; set; }
        [InverseProperty(nameof(Models.Department.Students))]
        public Department? Department { get; set; }
        #endregion
    }
}
