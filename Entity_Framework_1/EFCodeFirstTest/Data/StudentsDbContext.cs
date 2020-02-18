using EFCodeFirstTest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirstTest.Data
{
    public class StudentsDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring()
        {
            ;
        }
    }
}
