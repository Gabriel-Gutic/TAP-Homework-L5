using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Office : BaseModel
    {
        public string Devices { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Office(string devices, Guid employeeId) 
        { 
            Devices = devices;
            EmployeeId = employeeId;
        }
    }
}
