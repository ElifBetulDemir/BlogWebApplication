using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class WriterController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	public IActionResult Profile()
	{
		return View();
	}
		
	public IActionResult Mail()
	{
		return View();
	}

	public IActionResult Test()
	{
		return View();
	}

	public PartialViewResult NavbarPartial()
	{
		return PartialView();
	}

	public PartialViewResult FooterPartial()
	{
		return PartialView();
	}
}
