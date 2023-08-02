using Microsoft.EntityFrameworkCore;
using TodoProject.Models;

namespace TodoProject.Data;
public class TodoContext : DbContext
{

    public DbSet<Todo> Todos { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todo.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasMany(u => u.Todos).WithOne(t => t.User)
      .HasForeignKey(t => t.UserId);
    }


}