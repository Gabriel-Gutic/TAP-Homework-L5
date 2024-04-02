using DataLayer.Models;

namespace WebAPI.Dto
{
    public class PizzaDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public PizzaDto(string name, string description, float price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
