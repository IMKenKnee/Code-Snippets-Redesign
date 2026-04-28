using Microsoft.EntityFrameworkCore;
using CodeSnippets2.Data;
using CodeSnippets2.Models;

namespace CodeSnippets2.Services;

public class SnippetService : ISnippetService
{
    private readonly ApplicationDbContext _db;

    public SnippetService(ApplicationDbContext db)
    {
        _db = db;
    }

    public Snippet? GetById(int id)
    {
        return _db.Snippets
            .Include(s => s.Category)
            .FirstOrDefault(s => s.Id == id);
    }
}