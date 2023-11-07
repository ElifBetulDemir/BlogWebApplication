using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services;

public class CommentService : ICommentService
{
	private readonly ICommentRepository repository;

	public CommentService(ICommentRepository repository)
	{
		this.repository = repository;
	}
	public async Task Add(Comment comment)
	{
		_= await repository.Insert(comment);
	}

	public async Task<IEnumerable<Comment>> GetAll(int id)
	{
		return await repository.Where(x => x.BlogId == id);
	}
}
