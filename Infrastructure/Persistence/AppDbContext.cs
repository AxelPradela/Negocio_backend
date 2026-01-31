namespace Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;


public class AppDbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<DeliveryType> DeliveryTypes { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Status> Statuses { get; set; }
}