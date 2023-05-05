using CRUD.MODEL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.ServiceLayer
{
    public interface IEmployeeService
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAllEmployee();        
        void Create(Employee employee);
        void Edit(Employee employee);
        void Delete(Employee employee);
    }
}
