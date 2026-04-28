using Microsoft.AspNetCore.Mvc;
using CodeSnippets2.Services;

namespace CodeSnippets2.Controllers;

public class CategoriesController : Controller
{
    private readonly ICategoryService _service;

    public CategoriesController(ICategoryService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        return View(_service.GetAll());
    }

    public IActionResult Details(int id)
    {
        var category = _service.GetById(id);

        if (category == null)
        {
            return NotFound();
        }

        return View(category);
    }
}