using Blog.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class AboutController : Controller
{
	private readonly IAboutService aboutService;
	public AboutController(IAboutService aboutService)
	{
		this.aboutService = aboutService;
	}

	public IActionResult Index()
	{
		return View(aboutService.GetAll());
	}

	public PartialViewResult SocialMediaAbout()
	{
		return PartialView();
	}
}
