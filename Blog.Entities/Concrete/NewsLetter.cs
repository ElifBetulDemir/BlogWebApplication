using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete;

public class NewsLetter : BaseEntity
{
    public string Mail { get; set; }
}
