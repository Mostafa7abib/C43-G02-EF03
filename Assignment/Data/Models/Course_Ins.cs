using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Course_Ins
    {
        [ForeignKey("Instructor2")]
        public int Inst_id { get; set; }
        [ForeignKey("Course2")]
        public int Course_id { get; set; }
        public int Evaluate { get; set; }
        public Course Course2 { get; set; }
        public Instructor Instructor2 { get; set; }
    }
}
