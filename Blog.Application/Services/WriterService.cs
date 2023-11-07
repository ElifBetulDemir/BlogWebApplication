using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services;

public class WriterService : IWriterService
{
	private readonly IWriterRepository repository;
    public WriterService(IWriterRepository repository)
	{
		this.repository = repository;
	}
	public async Task Add(Writer writer)
	{
		await repository.Insert(writer);
	}

    public bool LoginPage(Writer writer)
    {
		var user = repository.FindByMail(writer.Mail, writer.Password);
		if (user!=null) 
		{
			return true;
        }
		return false;
    }
}
