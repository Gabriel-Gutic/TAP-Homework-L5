using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    // dotnet ef migrations add Initial
    // dotnet ef database update
    public class MyDbContext : DbContext
    {
        //private readonly string _windowsConnectionString = @"Server=.\SQLExpress;Database=Lab5Database1;Trusted_Connection=True;TrustServerCertificate=true";
        private readonly string _windowsConnectionString = @"Server=localhost\SQLEXPRESS;Database=Lab5Database1;Trusted_Connection=True;TrustServerCertificate=True;";

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_windowsConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Employee>()
                .HasOne(e => e.Office)
                .WithOne(o => o.Employee)
                .HasForeignKey<Office>(o => o.EmployeeId)
                .HasPrincipalKey<Employee>(e => e.Id);

            builder.Entity<Order>()
                .HasOne(o => o.Employee)
                .WithMany(e => e.Orders)
                .HasForeignKey(o => o.EmployeeId);

            builder.Entity<Pizza>()
                .HasMany(p => p.Orders)
                .WithMany(o => o.Pizzas)
                .UsingEntity<OrderPizza>();

            // Remove data from models
            builder.Entity<Employee>().HasData(new Employee[0]);
            builder.Entity<Office>().HasData(new Office[0]);
            builder.Entity<Pizza>().HasData(new Pizza[0]);
            builder.Entity<Order>().HasData(new Order[0]);

            Employee[] employees = 
            {
                new Employee("Gabi", 21),
                new Employee("Maria", 20),
                new Employee("Ana", 30)
            };

            builder.Entity<Employee>().HasData(employees);

            builder.Entity<Office>().HasData(
                   new Office("Computer, Laptop, Printer", employees[0].Id),
                   new Office("Laptop, Printer", employees[1].Id),
                   new Office("Computer", employees[2].Id)
                );

            Pizza[] pizzas =
            {
                new Pizza("Diavola", "Mozzarella, Salam Picant, Sos Picant", 32),
                new Pizza("Salami", "Mozzarella, Salam, Cabanos, Sos", 28),
                new Pizza("Capricioasa", "Mozzarella, Salam, Sunca, Sos", 34),
                new Pizza("Margherita", "Mozzarella, Branza", 24)
            };

            builder.Entity<Pizza>().HasData(pizzas);

            Order[] orders =
            {
                new Order(DateTime.Now, employees[0].Id),
                new Order(DateTime.Now, employees[1].Id),
                new Order(DateTime.Now, employees[2].Id),
                new Order(DateTime.Now, employees[0].Id),
            };

            builder.Entity<Order>().HasData(orders);

            builder.Entity<OrderPizza>().HasData(
                    new OrderPizza(orders[0].Id, pizzas[0].Id),
                    new OrderPizza(orders[0].Id, pizzas[1].Id),
                    new OrderPizza(orders[1].Id, pizzas[2].Id),
                    new OrderPizza(orders[2].Id, pizzas[2].Id),
                    new OrderPizza(orders[2].Id, pizzas[3].Id),
                    new OrderPizza(orders[3].Id, pizzas[0].Id),
                    new OrderPizza(orders[3].Id, pizzas[2].Id),
                    new OrderPizza(orders[3].Id, pizzas[3].Id)
                );
        }
    }
}
