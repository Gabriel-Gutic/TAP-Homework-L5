using DataLayer.Models;

namespace WebAPI.Dto
{
    public class OfficeDto
    {
        public string Devices { get; set; }
        public Guid EmployeeId { get; set; }

        public OfficeDto(string devices, Guid employeeId)
        {
            Devices = devices;
            EmployeeId = employeeId;
        }
    }
}
