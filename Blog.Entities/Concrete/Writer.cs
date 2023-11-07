using Blog.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete;

public class Writer:BaseEntity
{
    public string Name { get; set; }
    public string About { get; set; }
    public string? ImageUrl { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }
	public ICollection<Blog> Blogs { get; set; }
}
