using Demo.Data;
using Demo.Data.Models;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session03
            #region Connect With DB
            using CompanyDbContext dbContext = new CompanyDbContext(); // to open connection with database
            #endregion
            #region Crud Operations
            //#region Create || Insert
            //Employee Emp01 = new Employee()
            //{
            //    Name = "Mostafa",
            //    Age = 22,
            //    Salary = 2_000,
            //    EmailAdress = "mostafa123@gmail.com",
            //    PhoneNumber = "01234567891",
            //    Password = "jdlnasjl",
            //};
            //Employee Emp02 = new Employee()
            //{
            //    Name = "Ahmed",
            //    Age = 22,
            //    Salary = 3_000,
            //    EmailAdress = "Ahmed123@gmail.com",
            //    PhoneNumber = "6458986588",
            //    Password = "password",
            //};
            //Console.WriteLine(dbContext.Entry(Emp01).State); // here is DETACHED because i didn't add it in database
            //Console.WriteLine(dbContext.Entry(Emp02).State); //DETACHED
            //Console.WriteLine();
            ////dbContext.Employees.Add(Emp01);
            ////dbContext.Employees.Add(Emp02);
            //Console.WriteLine(dbContext.Entry(Emp01).State);
            //Console.WriteLine(dbContext.Entry(Emp02).State);
            //Console.WriteLine();
            //dbContext.SaveChanges(); 
            //Console.WriteLine(dbContext.Entry(Emp01).State); // unchanged
            //Console.WriteLine(dbContext.Entry(Emp02).State); // unchanged
            //Console.WriteLine("*********************************");
            //Console.WriteLine($"Emp01 => {Emp01.Code}");
            //Console.WriteLine($"Emp01 => {Emp02.Code}");
            //#endregion
            //#region Read || Retrieve
            //var Employee = (from E in dbContext.Employees
            //                where E.Code == 16
            //                select E).FirstOrDefault();
            //Console.WriteLine(Employee?.Name??"NotFound");
            //#endregion
            //#region Update
            //var Employee1 = (from E in dbContext.Employees
            //                 where E.Code == 17
            //                 select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee1).State);
            //Employee1.Name = "sasa";
            //Console.WriteLine(dbContext.Entry(Employee1).State);
            //dbContext.SaveChanges();
            //#endregion
            //#region Delete
            //var Employee2 = (from E in dbContext.Employees
            //                 where E.Code == 17
            //                 select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee2).State);
            //dbContext.Employees.Remove(Employee2);
            //Console.WriteLine(dbContext.Entry(Employee2).State);
            //dbContext.SaveChanges();
            //#endregion
            #endregion

            #endregion
        }
    }
}
