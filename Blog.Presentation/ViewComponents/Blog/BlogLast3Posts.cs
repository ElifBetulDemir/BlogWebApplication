using Blog.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.ViewComponents.Blog;

public class BlogLast3Posts : ViewComponent
{
	private readonly IBlogService blogService;
	public BlogLast3Posts(IBlogService blogService)
	{
		this.blogService = blogService;
	}

	public IViewComponentResult Invoke()
	{
		return View(blogService.GetLast3Blogs());
	}
}
