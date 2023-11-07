using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class ContactController : Controller
{
	private readonly IContactService contactService;
	public ContactController(IContactService contactService)
	{
		this.contactService = contactService;
	}
	public IActionResult Index()
	{
		return View();
	}

	[HttpPost]
	public IActionResult Index(Contact contact)
	{
		contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
		contact.Status = true;
		contactService.Add(contact);
		return RedirectToAction("Index", "Blog");
	}
}
