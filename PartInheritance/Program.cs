using PartInheritance.Data;
using PartInheritance.Data.Models;

namespace PartInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using RouteDbContext dbContext = new RouteDbContext();
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Mostafa",
                Age = 22,
                Address = "Helwan",
                StartDate = DateTime.Now,
                Salary = 5_000
            };
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Ahmed",
                Age = 21,
                Address = "ALex",
                CountOfHours = 20,
                HourRate = 2_00
            };
            //dbContext.Employees.Add(fullTimeEmployee);
            //dbContext.Employees.Add(partTimeEmployee);
            //dbContext.SaveChanges();
            var Employee = from employee in dbContext.Employees
                           select employee;
            foreach(var e in Employee.OfType<FullTimeEmployee>())
            {
                Console.WriteLine(e.Name);
            }
        }
    }
}
