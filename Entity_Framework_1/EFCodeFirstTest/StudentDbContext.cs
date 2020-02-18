using EFCodeFirstTest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstTest
{
    internal class StudentDbContext
    {
        public StudentDbContext()
        {
            ModelBuilder
                .Entity<Student> 
        }
    }
}