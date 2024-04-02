using DataLayer.Models;

namespace WebAPI.Dto
{
    public class OrderDto
    {
        public DateTime DateTime { get; set; }
        public Guid EmployeeId { get; set; }
        public ICollection<Guid> PizzaIds { get; set; }

        public OrderDto(DateTime dateTime, Guid employeeId, ICollection<Guid> pizzaIds)
        {
            DateTime = dateTime;
            EmployeeId = employeeId;
            PizzaIds = pizzaIds;
        }
    }
}
