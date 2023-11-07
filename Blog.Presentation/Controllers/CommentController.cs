using Blog.Application.Contracts;
using Blog.Application.Services;
using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Presentation.Controllers;

public class CommentController : Controller
{
	private readonly ICommentService commentService;
	public CommentController(ICommentService commentService)
	{
		this.commentService = commentService;
	}
	public IActionResult Index()
	{
		return View();
	}

	public PartialViewResult AddComment()
	{
		return PartialView();
	}

	[HttpPost]
	public async Task<PartialViewResult> AddComment(Comment comment)
	{
		comment.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
		comment.Status = true;
		comment.BlogId = 2;
		await commentService.Add(comment);
		return PartialView();
	}

}
