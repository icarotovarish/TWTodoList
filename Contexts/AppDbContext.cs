using Microsoft.EntityFrameworkCore;
using TWTodoList.Models;
namespace TWTodoList.Contetxs;

public class AppDbContext : DbContext
{
    public DbSet<Todo>
}
