using Blog.Application.Contracts;
using Blog.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.ViewComponents.Category;

public class CategoryList : ViewComponent
{
	private readonly ICategoryService categoryService;
	public CategoryList(ICategoryService categoryService)
	{
		this.categoryService = categoryService;
	}

	public IViewComponentResult Invoke()
	{
		return View(categoryService.GetAll());
	}
}
