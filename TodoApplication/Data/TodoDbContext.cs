using Microsoft.EntityFrameworkCore;
using TodoApplication.Models;

namespace TodoApplication.Data
{
    public class TodoDbContext : DbContext
    {

        public TodoDbContext(DbContextOptionsBuilder builder) : base(builder.Options)
        {
        }
        public DbSet<TodoItem> TodoItems
        {
            get; set;
        }
            // Metot ile ayarların yapılması
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        
          
            }
        }
        
