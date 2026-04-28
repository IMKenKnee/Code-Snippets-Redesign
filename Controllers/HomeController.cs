using Microsoft.AspNetCore.Mvc;
using CodeSnippets2.Services;

namespace CodeSnippets2.Controllers;

public class HomeController : Controller
{
    private readonly ICategoryService _categoryService;

    public HomeController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IActionResult Index()
    {
        var categories = _categoryService.GetAll();
        return View(categories);
    }
}