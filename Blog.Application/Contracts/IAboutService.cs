using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contracts;

public interface IAboutService
{
	public IEnumerable<About> GetAll();
}
