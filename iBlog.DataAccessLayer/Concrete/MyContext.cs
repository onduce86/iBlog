using iBlog.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace iBlog.DataAccessLayer.Concrete
{
    public class MyContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }



        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=iBlog;Trusted_Connection=True;");
            //optionsBuilder.UseSqlite("Data Source=Database.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasMany(c => c.Posts).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Post>().HasMany(p => p.Comments).WithOne(c => c.Post).HasForeignKey(c => c.PostId);
        }

    }
}
