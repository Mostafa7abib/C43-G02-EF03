using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateOnly CreationDate { get; set; }
        #region Work [Many]
        [InverseProperty(nameof(Models.Employee.Department))]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        #endregion
        #region Manage[One]
        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }  
        [InverseProperty(nameof(Models.Employee.ManageDepartment))]
        public Employee Manager { get; set; } = null!;
        #endregion
    }
}
