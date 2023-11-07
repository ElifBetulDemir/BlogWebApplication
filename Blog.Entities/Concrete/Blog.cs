using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string? ThumbnailImage { get; set; }
    public string ImageUrl { get; set; }
    public DateTime CreateDate { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int? WriterId { get; set; }
    public Writer Writer { get; set; }
    public ICollection<Comment> Comments { get; set; }
}
