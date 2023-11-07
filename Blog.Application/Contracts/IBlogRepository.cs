using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contracts;

public interface IBlogRepository : IBaseRepository<Entities.Concrete.Blog>
{
	public IEnumerable<Entities.Concrete.Blog> GetListWithCategory();
}
