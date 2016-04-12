using Core.Data.Entities;
using Core.Repository;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Service.Service
{
    public class EmployeeService : IEmployeeService
    {
         #region Fields

        private readonly IRepository<Employee> _employeeRepository;

        #endregion

        #region Constructors
        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        #endregion


        #region Methods
        public async Task Insert(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException("employee");

            await _employeeRepository.InsertAsync(employee);
        }

        public async Task Update(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException("employee");

            await _employeeRepository.UpdateAsync(employee);
        }

        public async Task Delete(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException("employee");

            await _employeeRepository.DeleteAsync(employee);
        }

        public async Task<Employee> GetEmployeeById(int employeeID)
        {
            if (employeeID == 0)
                return null;

            return await _employeeRepository.GetByIdAsync(employeeID);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var query = _employeeRepository.Table;
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByFirstName(string firstName)
        {
            var query = _employeeRepository.Table;

            if (!string.IsNullOrEmpty(firstName))
                query = query.Where(x => x.FirstName.ToLower().Contains(firstName.ToLower()));

            return await query.ToListAsync();
        }

        #endregion

       
    }
}
