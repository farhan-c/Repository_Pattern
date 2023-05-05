using CRUD.MODEL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Database
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAllEmployee();
        void Create(Employee employee);        
        void Delete(Employee employee);
        void Edit(Employee employee);

    }
}
