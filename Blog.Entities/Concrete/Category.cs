using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public ICollection<Blog> Blogs { get; set; }
}
