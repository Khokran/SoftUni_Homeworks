using EFCodeFirstTest.Data;
using EFCodeFirstTest.Data.Models;

namespace EFCodeFirstTest
{
    public class StartUp
    {
        public static void Main()
        {
            using var db = new StudentsDbContext();

            db.Database.EnsureCreated();

            db.Students.Add(new Student
            {
                FirstName = "Ivan",
                LastName = "Petrov",
                Type = StudentType.Enrolled()
            }) ;

        }
    }
}
