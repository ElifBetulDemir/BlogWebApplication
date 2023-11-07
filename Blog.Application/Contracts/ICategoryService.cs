using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contracts;

public interface ICategoryService
{
    public void Add(Category category);
    public IEnumerable<Category> GetAll();
    public Task<Category> GetById(int id);
    public void Delete(Category category);
    public void Update(Category category);
}
