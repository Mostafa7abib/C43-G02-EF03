using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateOnly Hiring_Date { get; set; }
        
        #region Have [Many]
        [InverseProperty(nameof(Models.Student.Department))]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        #endregion
        #region Include [Many]
        [InverseProperty(nameof(Models.Instructor.Departmentt))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        #endregion
        #region has[One]
        [ForeignKey(nameof(Instruct))]
        public int Ins_id { get; set; }
        [InverseProperty(nameof(Models.Instructor.Exist))]
        public Instructor Instruct { get; set; } = null!;
        #endregion

    }
}
