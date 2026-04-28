using Microsoft.AspNetCore.Mvc;
using CodeSnippets2.Services;

namespace CodeSnippets2.Controllers;

public class SnippetsController : Controller
{
    private readonly ISnippetService _service;

    public SnippetsController(ISnippetService service)
    {
        _service = service;
    }

    public IActionResult Details(int id)
    {
        return View(_service.GetById(id));
    }
}