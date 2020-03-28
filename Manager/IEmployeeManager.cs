using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    /// <summary>
    /// interface emloyee manager
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        EmployeeModel GetEmployee(int id);

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeModel> GetAllEmployees();

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        Task<int>   AddEmployee(EmployeeModel employee);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns></returns>
        Task<int>   UpdateEmployee(EmployeeModel employeeChanges);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        EmployeeModel DeleteEmployee(int id);
    }
}