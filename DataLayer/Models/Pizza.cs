using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Pizza : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public ICollection<Order> Orders { get; }

        public Pizza(string name, string description, float price) 
        { 
            Name = name;
            Description = description;
            Price = price;
            Orders = new List<Order>();
        }
    }
}
