using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Employee : BaseModel
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public Office Office { get; set; }

        public ICollection<Order> Orders { get; }
        public Employee(string name, int age) 
        { 
            Name = name;
            Age = age;
            Orders = new List<Order>();
        }
    }
}
