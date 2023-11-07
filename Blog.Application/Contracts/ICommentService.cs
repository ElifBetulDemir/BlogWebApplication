using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contracts;

public interface ICommentService
{
	public Task Add(Comment comment);
	public Task<IEnumerable<Comment>> GetAll(int id);
	//public Task<Comment> GetById(Guid id);
	//public void Delete(Comment comment);
	//public void Update(Comment comment);
}
