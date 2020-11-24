using Microsoft.EntityFrameworkCore;
using tech6_challenge_backend.Models;

namespace tech6_challenge_backend.Data{
    public class TodoContext: DbContext{
        public TodoContext(DbContextOptions<TodoContext> options):base(options)
        {
            
        }

        public DbSet<Todo> Todos { get; set; }
    }
}