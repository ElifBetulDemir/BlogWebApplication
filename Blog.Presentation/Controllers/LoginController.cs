using Blog.Application.Contracts;
using Blog.Application.Services;
using Blog.Entities.Concrete;
using Blog.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class LoginController : Controller
{
	private readonly IWriterService _writerService;
    public LoginController(IWriterService writerService)
    {
        _writerService = writerService;
    }
    //[AllowAnonymous]
	public IActionResult Index()
	{
		return View();
	}
	[HttpPost]
    public IActionResult Index(Writer writer)
    {
        var result = _writerService.LoginPage(writer);
        if (result)
        {
            return RedirectToAction("Test", "Writer");
        }
        else
        {
            return View();
        }
    }
}
