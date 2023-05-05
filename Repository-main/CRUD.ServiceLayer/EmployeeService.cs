using CRUD.Database;
using CRUD.MODEL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.ServiceLayer
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void Create(Employee employee)
        {
            employeeRepository.Create(employee);
        }

        public void Delete(Employee employee)
        {
            employeeRepository.Delete(employee);
        }

        public void Edit(Employee employee)
        {
            employeeRepository.Edit(employee);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employeeRepository.GetAllEmployee();
        }

        public Employee GetEmployeeById(int id)
        {
            return employeeRepository.GetEmployeeById(id);
        }
    }
}
