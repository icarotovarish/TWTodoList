using Microsoft.EntityFrameworkCore;
using TWTodoList.EntiyConfigs;
using TWTodoList.Models;
namespace TWTodoList.Contetxs;

public class AppDbContext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();
    protected override void OnConfiguring (DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=Localhost;Database=TWTodoList; Trusted_Connection = true");
    }
    protected override void OnModelCreating (ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoEntityConfig());
    }
}
