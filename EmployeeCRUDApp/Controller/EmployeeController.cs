//-----------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Mayank Sachdeva"/>
//-----------------------------------------------------------------------

namespace EmployeeCRUDApp.Controller
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Manager;
    using Microsoft.AspNetCore.Mvc;
    using Model;
    using Serilog;


    /// <summary>
    /// controller class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        public readonly IEmployeeManager Manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public EmployeeController(IEmployeeManager manager)
        {
            this.Manager = manager;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns> action result type</returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model.EmployeeModel employee)
        {
            var result = await this.Manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                Log.Error("This is a Bad Request");
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns> Employee Model</returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            Log.Information("All Employees loaded");
            return this.Manager.GetAllEmployees();
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns>action result type</returns>
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var result = await this.Manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                Log.Information("Existing Employee Updated");
                return this.Ok(employeeChanges);
            }
            else
            {
                Log.Error("This is a Bad Request");
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>employee model type</returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public EmployeeModel DeleteEmployee(int id)
        {
            Log.Information("Employee Deleted");
            return this.Manager.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>employee model</returns>
        [Route("GetEmployee")]
        [HttpGet]
        public EmployeeModel GetEmployee(int id)
        {
            return this.Manager.GetEmployee(id);
        }

        [Route("LoginEmployee")]
        [HttpPost]
        public IActionResult LoginEmployee(string email, string password)
        {
            var result = this.Manager.LoginEmployee(email, password);
            if (result == true)
            {
                return this.Ok(email);
            }
            else
            {
                return this.BadRequest();
            }
        }
    }
} 