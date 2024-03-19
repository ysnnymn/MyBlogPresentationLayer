using System;
using Microsoft.EntityFrameworkCore;
using MyBlog.EntitiyLayer.Concrete;

namespace MyProject.DataAccessLayer.Context
{
	public class BlogContext:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog =DbMyBlog; User ID = SA; Password = Yasinyaman.43; Connect Timeout = 10; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}

