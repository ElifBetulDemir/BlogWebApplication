using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.ViewComponents.Writer;

public class WriterNotification : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
