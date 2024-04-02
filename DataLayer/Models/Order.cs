using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Order : BaseModel
    {
        public DateTime DateTime { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Pizza> Pizzas { get; }

        public Order(DateTime dateTime, Guid employeeId)
        {
            DateTime = dateTime;
            EmployeeId = employeeId;
            Pizzas = new List<Pizza>();
        }
    }
}
