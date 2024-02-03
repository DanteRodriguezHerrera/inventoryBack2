using Microsoft.EntityFrameworkCore;

namespace InventoryBack.Models
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Inventory> InventoryDetails { get; set; }
    }
}
