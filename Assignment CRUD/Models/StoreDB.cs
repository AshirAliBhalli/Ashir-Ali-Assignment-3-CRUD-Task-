using Microsoft.EntityFrameworkCore;

namespace Assignment_CRUD.Models
{
    public class StoreDB : DbContext
    {
        public StoreDB(DbContextOptions<StoreDB> options) : base(options) {}
        public DbSet<Order> Orders { get; set}

    }
}
