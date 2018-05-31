using Microsoft.EntityFrameworkCore;

namespace WebApp.EntityFramework
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Item> Items { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
    }
}