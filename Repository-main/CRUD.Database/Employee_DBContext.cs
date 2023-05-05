using CRUD.MODEL.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Database
{
    public class Employee_DBContext:DbContext
    {
        public Employee_DBContext():base("name=Employee_DBContext") 
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
