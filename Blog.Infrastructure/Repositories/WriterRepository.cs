using Blog.Application.Contracts;
using Blog.Entities.Concrete;
using Blog.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories;

public class WriterRepository : BaseRepository<Writer>, IWriterRepository
{
    public WriterRepository(BlogContext context) : base(context)
    {
    }
    public Writer FindByMail(string email, string password)
    {
        return context.Writers.FirstOrDefault(x => x.Mail == email && x.Password == password);
    }
}
