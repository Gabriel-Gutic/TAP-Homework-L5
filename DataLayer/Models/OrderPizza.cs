using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class OrderPizza : BaseModel
    {
        public Guid OrderId { get; set; }
        public Guid PizzaId { get; set; }

        public OrderPizza()
        {

        }

        public OrderPizza(Guid orderId, Guid pizzaId) 
        {
            OrderId = orderId;
            PizzaId = pizzaId;
        }
    }
}
