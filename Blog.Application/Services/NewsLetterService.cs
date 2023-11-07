using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services;

public class NewsLetterService : INewsLetterService
{
	private readonly INewsLetterRepository repository;

	public NewsLetterService(INewsLetterRepository repository)
	{
		this.repository = repository;
	}

	public async Task AddNewsLetter(NewsLetter newsLetter)
	{
		_= await repository.Insert(newsLetter);
	}
}
