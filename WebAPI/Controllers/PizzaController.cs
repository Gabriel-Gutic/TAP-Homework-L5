using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IRepository<Pizza> _pizzaRepository;


        public PizzaController(IRepository<Pizza> pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        [HttpGet("getall")]
        public IEnumerable<PizzaDto> GetAll()
        {
            return _pizzaRepository.GetAll()
                .Select(pizza => new PizzaDto(pizza.Name, pizza.Description, pizza.Price));
        }

        [HttpPost("insert")]
        public void Insert(PizzaDto pizza)
        {
            _pizzaRepository.Add(new Pizza(
                pizza.Name,
                pizza.Description,
                pizza.Price));

            _pizzaRepository.SaveChanges();
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid pizzaId, PizzaDto pizza)
        {
            var pizzaFromDb = _pizzaRepository.GetById(pizzaId);

            if (pizzaFromDb == null)
            {
                return NotFound("Pizza not found");
            }

            pizzaFromDb.Name = pizza.Name;
            pizzaFromDb.Description = pizza.Description;
            pizzaFromDb.Price = pizza.Price;

            _pizzaRepository.SaveChanges();

            return Ok("Pizza updated succesfully");
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(Guid pizzaId)
        {
            var pizzaFromDb = _pizzaRepository.GetById(pizzaId);

            if (pizzaFromDb == null)
            {
                return NotFound("Pizza not found");
            }

            _pizzaRepository.Remove(pizzaFromDb);
            _pizzaRepository.SaveChanges();

            return Ok("Pizza removed succesfully");
        }
    }
}
