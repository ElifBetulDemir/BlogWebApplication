using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class NewsLetterController : Controller
{
	private readonly INewsLetterService newsLetterService;
	public NewsLetterController(INewsLetterService newsLetterService)
	{
		this.newsLetterService = newsLetterService;
	}

	public PartialViewResult SubscribeMail()
	{
		return PartialView();
	}

	[HttpPost]
	public async Task<PartialViewResult> SubscribeMail(NewsLetter newsLetter)
	{
		newsLetter.Status = true;
		await newsLetterService.AddNewsLetter(newsLetter);
		return PartialView();
	}
}
