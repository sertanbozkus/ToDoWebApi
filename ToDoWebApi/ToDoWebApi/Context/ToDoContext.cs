using Microsoft.EntityFrameworkCore;
using ToDoWebApi.Entities;

namespace ToDoWebApi.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }

        public DbSet<ToDoEntity> ToDos => Set<ToDoEntity>();

    }
}
