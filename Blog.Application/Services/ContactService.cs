using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services;

public class ContactService : IContactService
{
	private readonly IContactRepository repository;

	public ContactService(IContactRepository repository)
	{
		this.repository = repository;
	}

	public async Task Add(Contact contact)
	{
		_= await repository.Insert(contact);
	}
}
