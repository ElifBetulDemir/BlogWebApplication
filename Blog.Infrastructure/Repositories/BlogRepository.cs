using Blog.Application.Contracts;
using Blog.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories;

public class BlogRepository : BaseRepository<Entities.Concrete.Blog>, IBlogRepository
{
    public BlogRepository(BlogContext context) : base(context)
    {
    }

	public IEnumerable<Entities.Concrete.Blog> GetListWithCategory()
	{
		return context.Blogs.Include(x => x.Category).ToList();
	}
}
