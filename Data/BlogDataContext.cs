using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data{

    public class BlogDataContext : DbContext{

        public DbSet<Category> Categories { get; set; }
        public DbSet<Category> Posts { get; set; }
        //public DbSet<Category> PostTags { get; set; }
        public DbSet<Category> Roles { get; set; }
        public DbSet<Category> Tags { get; set; }
        public DbSet<Category> Users { get; set; }
        //public DbSet<Category> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=123MudaR");
        }
    }
}