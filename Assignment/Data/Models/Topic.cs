using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    internal class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [InverseProperty(nameof(Models.Course.HasTopic))]
        public ICollection<Course> Topicc { get; set; } = new HashSet<Course>();
    }
}
