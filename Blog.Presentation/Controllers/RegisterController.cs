using Blog.Application.Contracts;
using Blog.Application.ValidationRules;
using Blog.Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class RegisterController : Controller
{
	private readonly IWriterService writerService;
	public RegisterController(IWriterService writerService)
	{
		this.writerService = writerService;
	}
	public IActionResult Index()
	{
		return View();
	}

	[HttpPost]
	public IActionResult Index(Writer writer)
	{
		WriterValidator wv = new WriterValidator();
		ValidationResult results = wv.Validate(writer);
		if (results.IsValid)
		{
			writer.Status = true;
			writer.About = "Deneme Test";
			writerService.Add(writer);
			return RedirectToAction("Index", "Blog");
		}
		else
		{
			foreach(var item in results.Errors)
			{
				ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
			}
		}
		return View();
	}
}
