using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IRepository<Office> _officeRepository;

        public OfficeController(IRepository<Office> officeRepository)
        {
            _officeRepository = officeRepository;
        }

        [HttpGet("getall")]
        public IEnumerable<OfficeDto> GetAll()
        {
            return _officeRepository.GetAll()
                .Select(office => new OfficeDto(office.Devices, office.EmployeeId));
        }

        [HttpPost("insert")]
        public void Insert(OfficeDto office) 
        {
            _officeRepository.Add(new Office(office.Devices, office.EmployeeId));
            _officeRepository.SaveChanges();
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid officeId, OfficeDto office)
        {
            var officeFromDb = _officeRepository.GetById(officeId);

            if (officeFromDb == null)
            {
                return NotFound("Office not found");
            }

            officeFromDb.Devices = office.Devices;
            officeFromDb.EmployeeId = office.EmployeeId;

            _officeRepository.SaveChanges();

            return Ok("Office updated succesfully");
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(Guid officeId)
        {
            var officeFromDb = _officeRepository.GetById(officeId);

            if (officeFromDb == null)
            {
                return NotFound("Office not found");
            }

            _officeRepository.Remove(officeFromDb);
            _officeRepository.SaveChanges();

            return Ok("Office removed succesfully");
        }
    }
}
