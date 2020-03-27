using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUDApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IManager manager;
        public EmployeeController(IManager manager)
        {
            this.manager = manager;
        }

        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model.EmployeeModel employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(EmployeeModel employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }
        [HttpDelete]
        [Route("DeleteEmployee")]
        public EmployeeModel DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }
        [Route("GetEmployee")]
        [HttpGet]
        public EmployeeModel GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }
    }
} 