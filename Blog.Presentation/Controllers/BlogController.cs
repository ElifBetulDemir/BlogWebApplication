using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class BlogController : Controller
{
	private readonly IBlogService blogService;
	public BlogController(IBlogService blogService)
	{
		this.blogService = blogService;
	}
	public IActionResult Index()
	{
		return View(blogService.GetBlogListWithCategory());
	}
	public async Task<IActionResult> ReadAll(int id)
	{
		ViewBag.Id = id;
		return View(await blogService.GetById(id));
	}
	public IActionResult AddBlog()
	{
		return View();
	}
	[HttpPost]
    public IActionResult AddBlog(Blog.Entities.Concrete.Blog blog)
    {
		blogService.Add(blog);
        return View();
    }
    public IActionResult UpdateBlog(int id)
    {
        return View();
    }
    [HttpPost]
    public IActionResult UpdateBlog(Blog.Entities.Concrete.Blog blog)
    {
        blogService.Update(blog);
        return View();
    }
	[HttpPost]
    public IActionResult DeleteBlog(Entities.Concrete.Blog blog)
    {
		blogService.Delete(blog);
        return View();
    }
}
