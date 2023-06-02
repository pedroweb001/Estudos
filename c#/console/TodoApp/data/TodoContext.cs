using Microsoft.EntityFrameworkCore;
using TodoApp.models;

namespace TodoApp.data
{
    public class TodoContext:DbContext
    {

 public DbSet<Todo> Todos{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = todos.db");
        }
    }
}