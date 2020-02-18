using System;
using System.Text;
using System.Collections.Generic;

namespace EFCoreDemoTest.Data
{
    public partial class Employees
    {
        public Employees 
        {
            Departments = new HashSet<Departments>();
            EmployeesProjects =  new HashSet<EmployeesProjects>();
            InverseManager =  new HashSet<Employees>();
        }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddletName { get; set; }
        public string JobTitle { get; set; }
        public int DepartmentId { get; set; }
        public int? ManagerId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public virtual Addresses Address { get; set; }
        public virtual Departments Department  { get; set; }
        public virtual Employees Manager { get; set; }
}
}
