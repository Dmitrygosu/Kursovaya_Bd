using Data.Models;
using System.Data.Entity;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<FileTableModel> Files { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
