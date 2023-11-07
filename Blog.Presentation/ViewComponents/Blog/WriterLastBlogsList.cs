using Blog.Application.Contracts;
using Blog.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.ViewComponents.Blog;

public class WriterLastBlogsList : ViewComponent
{
	private readonly IBlogService blogService;
	public WriterLastBlogsList(IBlogService blogService)
	{
		this.blogService = blogService;
	}

	public async Task<IViewComponentResult> InvokeAsync()
	{
		return View(await blogService.GetListByWriter(1));
	}
}
