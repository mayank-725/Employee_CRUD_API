//-----------------------------------------------------------------------
// <copyright file="IEmployeeRepository.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Mayank Sachdeva"/>
//-----------------------------------------------------------------------

namespace Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;

    /// <summary>
    /// employee repository
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>employee model type</returns>
      EmployeeModel GetEmployee(int id);

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>employee model type</returns>
        IEnumerable<EmployeeModel> GetAllEmployees();

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>task integer type</returns>
        Task<int> AddEmployee(EmployeeModel employee);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns>task integer type</returns>
        Task<int> UpdateEmployee(EmployeeModel employeeChanges);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>employee model type</returns>
        EmployeeModel DeleteEmployee(int id);

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        bool LoginEmployee(string email, string password);
    }
}
