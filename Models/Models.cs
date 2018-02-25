using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace spa.Models
{
    public class SpaContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source=spa.db");
        }
    }

    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MailAddress { get; set; }
    }
}