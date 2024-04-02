using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IRepository<Employee> _employeeRepository;

        public EmployeeController(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("getall")]
        public IEnumerable<EmployeeDto> GetAll()
        {
            return _employeeRepository.GetAll()
                .Select(employee => new EmployeeDto(employee.Name, employee.Age));
        }

        [HttpPost("insert")]
        public void Insert(EmployeeDto employee)
        {
            _employeeRepository.Add(new Employee(
                employee.Name, 
                employee.Age));

            _employeeRepository.SaveChanges();
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid employeeId, EmployeeDto employee)
        {
            var employeeFromDb = _employeeRepository.GetById(employeeId);

            if (employeeFromDb == null)
            {
                return NotFound("Employee not found");
            }

            employeeFromDb.Name = employee.Name;
            employeeFromDb.Age = employee.Age;

            _employeeRepository.SaveChanges();

            return Ok("Employee updated succesfully");
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(Guid employeeId)
        {
            var employeeFromDb = _employeeRepository.GetById(employeeId);

            if (employeeFromDb == null)
            {
                return NotFound("Employee not found");
            }

            _employeeRepository.Remove(employeeFromDb);
            _employeeRepository.SaveChanges();

            return Ok("Employee removed succesfully");
        }
    }
}
