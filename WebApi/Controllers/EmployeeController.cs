using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmpDbContext _db;
        public EmployeeController(EmpDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult GetEmployees()
        {
            var employees = _db.Employees.ToList();

            return Ok(employees);
        }
        [HttpGet("{id}")]
        public ActionResult GetEmployeeById(int id)
        {
            var employee = _db.Employees.FirstOrDefault(x => x.Id == id);

            return Ok(employee);
        }
    }
}
