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
                Address = "Helwan",
                Salary = 3_000,
                Age = 22,
                StartDate = DateTime.Now,
            };
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            { 
                Name = "Ahmed",
                Age = 21,
                Address = "Alex",
                CountOfHours = 3,
                HourRate = 1_00
            };
            Console.WriteLine(dbContext.Entry(fullTimeEmployee).State);
            dbContext.fullTimeEmployees.Add(fullTimeEmployee);
            Console.WriteLine(dbContext.Entry(fullTimeEmployee).State);
            dbContext.partTimeEmployees.Add(partTimeEmployee);
            Console.WriteLine(dbContext.Entry(partTimeEmployee).State);
            dbContext.SaveChanges();
            var FTE = (from FT in dbContext.fullTimeEmployees
                       where FT.Id == 1
                       select FT).FirstOrDefault();
            Console.WriteLine(FTE?.Name??"NotFound");
            Console.WriteLine();
            var PTE = (from PT in dbContext.partTimeEmployees
                       where PT.Id == 1
                       select PT).FirstOrDefault();
            Console.WriteLine(PTE?.Name ?? "NotFound");
        }
    }
}
