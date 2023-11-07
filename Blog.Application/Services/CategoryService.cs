using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository repository;

    public CategoryService(ICategoryRepository repository)
    {
        this.repository = repository;
    }
    public void Add(Category category)
    {
        repository.Insert(category);
    }

    public void Delete(Category category)
    {
        repository.Delete(category);
    }

    public IEnumerable<Category> GetAll()
    {
        return repository.GetAll();
    }

    public async Task<Category> GetById(int id)
    {
        return await repository.Find(id);
    }

    public void Update(Category category)
    {
        repository.Update(category);
    }
}
