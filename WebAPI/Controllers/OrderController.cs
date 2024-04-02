using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Pizza> _pizzaRepository;

        public OrderController(IRepository<Order> orderRepository, IRepository<Pizza> pizzaRepository)
        {
            _orderRepository = orderRepository;
            _pizzaRepository = pizzaRepository;
        }

        [HttpGet("get")]
        public IEnumerable<OrderDto> Get()
        {
            return _orderRepository.Include(o => o.Pizzas).ToList()
                .Select(o =>
                {
                    return new OrderDto(
                        o.DateTime,
                        o.EmployeeId,
                        o.Pizzas.Select(p => p.Id).ToList());
                });
        }

        [HttpPost("insert")]
        public ObjectResult Insert(OrderDto order)
        {
            Order newOrder = new Order(
                order.DateTime,
                order.EmployeeId);

            var pizzas = _pizzaRepository.GetByIds(order.PizzaIds);
            
            if (pizzas == null || pizzas.Count() != order.PizzaIds.Count)
            {
                return NotFound("Pizza not found");
            }

            foreach (var pizza in pizzas)
            {
                newOrder.Pizzas.Add(pizza);
            }

            _orderRepository.Add(newOrder);
            _orderRepository.SaveChanges();

            return Ok("Order inserted succesfully");
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid orderId, OrderDto order)
        {
            var orderFromDb = _orderRepository.GetById(orderId);

            if (orderFromDb == null)
            {
                return NotFound("Order not found");
            }

            orderFromDb.DateTime = order.DateTime;
            orderFromDb.EmployeeId = order.EmployeeId;

            var pizzas = _pizzaRepository.GetByIds(order.PizzaIds);

            if (pizzas == null)
            {
                return NotFound("Pizza not found");
            }

            orderFromDb.Pizzas.Clear();
            foreach (var pizza in pizzas)
            {
                orderFromDb.Pizzas.Add(pizza);
            }

            _orderRepository.SaveChanges();

            return Ok("Order updated succesfully");
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(Guid orderId)
        {
            var orderFromDb = _orderRepository.GetById(orderId);

            if (orderFromDb == null)
            {
                return NotFound("Order not found");
            }

            _orderRepository.Remove(orderFromDb);
            _orderRepository.SaveChanges();

            return Ok("Order removed succesfully");
        }
    }
}
