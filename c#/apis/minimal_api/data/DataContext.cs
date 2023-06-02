using Microsoft.EntityFrameworkCore;

namespace minimal_api
{
    public class DataContext : DbContext
    {

        public DbSet<Todo> Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        }
    }
}