using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contracts;

public interface IBlogService
{
	public void Add(Entities.Concrete.Blog blog);
	public IEnumerable<Entities.Concrete.Blog> GetAll();
	public IEnumerable<Entities.Concrete.Blog> GetBlogListWithCategory();
	public Task<IEnumerable<Entities.Concrete.Blog>> GetById(int id);
	public IEnumerable<Entities.Concrete.Blog> GetLast3Blogs();
	public Task<IEnumerable<Entities.Concrete.Blog>> GetListByWriter(int id);
	public void Delete(Entities.Concrete.Blog blog);
	public void Update(Entities.Concrete.Blog blog);
}
