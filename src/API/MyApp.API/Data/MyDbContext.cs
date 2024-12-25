using Microsoft.EntityFrameworkCore;
using MyApp.API.Models;

namespace MyApp.API.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {

    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
