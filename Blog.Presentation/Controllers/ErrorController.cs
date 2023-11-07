using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class ErrorController : Controller
{
	public IActionResult Error1(int code)
	{
		return View();
	}
}
