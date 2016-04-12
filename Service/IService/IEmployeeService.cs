using Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IEmployeeService
    {
        Task Insert(Employee employee);

        Task Update(Employee employee);

        Task Delete(Employee employee);

        Task<Employee> GetEmployeeById(int employeeID);

        Task<IEnumerable<Employee>> GetAllEmployees();

        Task<IEnumerable<Employee>> GetEmployeesByFirstName(string firstName);
    }
}
