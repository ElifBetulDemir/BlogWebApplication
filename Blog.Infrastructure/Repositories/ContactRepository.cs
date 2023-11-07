using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using Blog.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories;

public class ContactRepository : BaseRepository<Contact>, IContactRepository
{
    public ContactRepository(BlogContext context) : base(context)
    {
    }
}
