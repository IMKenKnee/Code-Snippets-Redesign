using Microsoft.EntityFrameworkCore;
using CodeSnippets2.Data;
using CodeSnippets2.Models;

namespace CodeSnippets2.Services;

public class CategoryService : ICategoryService
{
    private readonly ApplicationDbContext _db;

    public CategoryService(ApplicationDbContext db)
    {
        _db = db;
    }

    public List<Category> GetAll()
    {
        return _db.Categories
            .Include(c => c.Snippets)
            .ToList();
    }

    public Category? GetById(int id)
    {
        return _db.Categories
            .Include(c => c.Snippets)
            .FirstOrDefault(c => c.Id == id);
    }
}