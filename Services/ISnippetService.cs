using CodeSnippets2.Models;

namespace CodeSnippets2.Services;

public interface ISnippetService
{
    Snippet? GetById(int id);
}