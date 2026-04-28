using CodeSnippets2.Models;

namespace CodeSnippets2.Services;

public interface ICategoryService
{
    List<Category> GetAll();
    Category? GetById(int id);
}