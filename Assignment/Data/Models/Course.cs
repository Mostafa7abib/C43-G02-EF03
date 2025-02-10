using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public ICollection<Std_Courses> Courses { get; set; } = new HashSet<Std_Courses>(); 
       public ICollection<Course_Ins> Courses_Ins { get; set;} = new HashSet<Course_Ins>();
        #region Topic[One]
        [ForeignKey(nameof(HasTopic))]
        public int Top_id { get; set; }
        [InverseProperty(nameof(Models.Topic.Topicc))]
        public Topic HasTopic { get; set; } = null!;
        #endregion
    }
}
