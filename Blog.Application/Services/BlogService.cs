using Blog.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services;

public class BlogService : IBlogService
{
	private readonly IBlogRepository repository;

	public BlogService(IBlogRepository repository)
	{
		this.repository = repository;
	}
	public void Add(Entities.Concrete.Blog blog)
	{
		repository.Insert(blog);
	}

	public void Delete(Entities.Concrete.Blog blog)
	{
		repository.Delete(blog);
	}

	public IEnumerable<Entities.Concrete.Blog> GetAll()
	{
		return repository.GetAll();
	}

	public IEnumerable<Entities.Concrete.Blog> GetBlogListWithCategory()
	{
		return repository.GetListWithCategory();
	}

	public async Task<IEnumerable<Entities.Concrete.Blog>> GetById(int id)
	{
		return await repository.Where(x => x.Id == id);
	}

	public IEnumerable<Entities.Concrete.Blog> GetLast3Blogs()
	{
		return repository.GetAll().Take(3);
	}

	public async Task<IEnumerable<Entities.Concrete.Blog>> GetListByWriter(int id)
	{
		return await repository.Where(x => x.WriterId == id);
	}

	public void Update(Entities.Concrete.Blog blog)
	{
		repository.Update(blog);
	}
}
