using Blog.Entities.Concrete;
using Blog.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Persistence.Context;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Entities.Concrete.Blog> Blogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Writer> Writers { get; set; }
    public DbSet<NewsLetter> NewsLetters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        new CategoryConfiguration().Configure(modelBuilder.Entity<Category>());
        new BlogConfiguration().Configure(modelBuilder.Entity<Entities.Concrete.Blog>());
        new CommentConfiguration().Configure(modelBuilder.Entity<Comment>());
        new WriterConfiguration().Configure(modelBuilder.Entity<Writer>());
        new AboutConfiguration().Configure(modelBuilder.Entity<About>());
		base.OnModelCreating(modelBuilder);
	}
}
