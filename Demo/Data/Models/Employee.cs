using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    internal class Employee
    {
        [Key] // make Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //make Identity (1,1)
        public int Code { get; set; }

        [Column(TypeName = "varchar")]
        //[StringLength(50,MinimumLength =10)]
        //[MinLength(10)]
        public string? Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public double Salary { get; set; }
        [Range(22, 60)]
        //[AllowedValues(20,21)]
        [DeniedValues(44, 45)]
        public int? Age { get; set; }
        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAdress { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
