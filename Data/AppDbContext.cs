using Microsoft.EntityFrameworkCore;
using PizzaTest.Models;

namespace PizzaTest.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<PizzaModel> Pizzas { get; set; }
}
