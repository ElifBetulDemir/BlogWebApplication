using Blog.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class CategoryController : Controller
{
    private readonly ICategoryService categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        this.categoryService = categoryService;
    }
    public IActionResult Index()
    {
        return View(categoryService.GetAll());
    }
}
