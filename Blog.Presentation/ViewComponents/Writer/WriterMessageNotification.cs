using Blog.Application.Contracts;
using Blog.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.ViewComponents.Writer;

public class WriterMessageNotification : ViewComponent
{
	private readonly IWriterService writerService;
	public WriterMessageNotification(IWriterService writerService)
	{
		this.writerService = writerService;
	}

	public IViewComponentResult Invoke()
	{
		return View();
	}
}
