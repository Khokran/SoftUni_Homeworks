using System;
using System.Linq;
using EFCoreDemoTest.Data;
using EFCoreDemoTest.Results;

namespace EFCoreDemoTest
{
    public static class Program
    {
        private static bool Filter(string name)
        {
            return name.Length == 4;
        }
        public static void Main(string[] args)
        {
            using (var db = new SoftUniContext())
            {
                var result = db.Towns
                    .Where(t => t.Name.StartsWith("A"))
                    .Select(t => new TownResultModel
                    {
                        Name = t.Name,
                        Addresses = t.Addresses
                        .Select(a => a.AddressText)
                        .OrderBy(a => a.Length)
                    })
                    .ToList()
                    .Where(t => t.Filter(t.Name));

                foreach (var town in result)
                {
                    Console.WriteLine(town);
                }
            }
        }
        public static void Main()
        {
            using var db = new SoftUniContext();

            var result = db.Employees
                .Select(e => new EmployeeResultModel
                {
                    Name = e.FirstName + " " + e.LastName,
                    Department = e.Department.Name
                })
                .ToList();

            foreach (var empl in result)
            {
                Console.WriteLine(empl.Department + ": " + empl.Name);
            }
        }

        //  public static void Main()                             //  public static void Main()               
        //  {                                                     //  {                                       
        //      using var db = new SoftUniContext();              //      using var db = new SoftUniContext();
        //                                                        //      var town = db.Towns.Find(33);                                    
        //      db.Add(new Town                                   //                           
        //      {                                                 //      town.Name = "Old Town";
        //          Name = "New Town"                             //                     
        //      });                                               //                                      
        //      db.SaveChanges();                                 //      db.SaveChanges();                   
        //  }                                                     //  }
    }                                                               
                                                                    
}                                                                 //  public static void Main()               
                                                                  //  {                                       
                                                                  //      using var db = new SoftUniContext();
                                                                  //                           
                                                                  //      db.Towns.Remove(new Town{TownId = 33});
                                                                  //                                      
                                                                  //      db.SaveChanges();                   
                                                                  //  }
