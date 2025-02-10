using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Std_Courses
    {
        [ForeignKey(nameof(Stu_dent))]
        public int Stud_id { get; set; }
        [ForeignKey(nameof(Cou_rse))]
        public int Course_id { get; set; }
        public int Grarde { get; set; }
        public Student Stu_dent { get; set; }
        public Course Cou_rse { get; set; }
    }
}
