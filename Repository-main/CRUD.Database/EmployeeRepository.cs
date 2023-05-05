using CRUD.MODEL.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Database
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Employee_DBContext db;
        public EmployeeRepository(Employee_DBContext db)
        {
            this.db = db;
        }
        public void Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            db.Employees.Remove(employee);
            db.SaveChanges() ;
        }

        public void Edit(Employee employee)
        {
            db.Entry(employee).State=EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            //return db.Employees.Where(x=>x.Id == id).FirstOrDefault();
            return db.Employees.Find(id);
        }
    }
}
