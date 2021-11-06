using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Blog.Data.Mappings;

namespace Blog.Data{

    public class BlogDataContext : DbContext{

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            
            options.UseSqlServer("Server=localhost;Database=Blog;User ID=sa;Password=123MudaR");
            //options.LogTo(Console.WriteLine); Mostrar os logs
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());

        }
    }
}