using System;
using MiniORM;
using System.Text;
using System.Collections.Generic;

namespace EFCoreDemoTest.Data
{
    public class SoftUniContext
    {
        public IEnumerable<object> Employees { get; internal set; }
    }
    public virtual DbSet<Addresses> Addresses { get; set; }
    public virtual DbSet<Departments> Departments { get; set; }
    public virtual DbSet<Employees> Employees { get; set; }
    public virtual DbSet<EmployeesProjects> EmployeesProjects { get; set; }
    public virtual DbSet<Projects> Projects { get; set; }
    public virtual DbSet<Town> Towns { get; set; }
    
    protected override void OnConfiguring(DbContextOptionBuilder optionBuilder)
    {
        if (!optionBuilder.IsConfigured)
        {
            optionBuilder
        }
    }
}
