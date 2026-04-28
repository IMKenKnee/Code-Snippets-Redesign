using Microsoft.EntityFrameworkCore;
using CodeSnippets2.Models;

namespace CodeSnippets2.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Snippet> Snippets => Set<Snippet>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Snippets)
            .WithOne(s => s.Category)
            .HasForeignKey(s => s.CategoryId);
    }
}