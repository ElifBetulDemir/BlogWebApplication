using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services;

public class AboutService : IAboutService
{
	private readonly IAboutRepository repository;

	public AboutService(IAboutRepository repository)
	{
		this.repository = repository;
	}

	public IEnumerable<About> GetAll()
	{
		return repository.GetAll();
	}
}
