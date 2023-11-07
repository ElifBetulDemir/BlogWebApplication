using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Persistence.Configuration;

public class WriterConfiguration : IEntityTypeConfiguration<Writer>
{
	public void Configure(EntityTypeBuilder<Writer> builder)
	{
		builder.HasData(
			new Writer() { Id = 1, Name = "Bahadır Hakan", About = "Deneme", Mail = "bahadirhakan@blog.com", Password = "111", Status = true },
			new Writer() { Id = 2, Name = "Ayşe Çınar", About = "Deneme", Mail = "aysecinar@blog.com", Password = "333", Status = true },
			new Writer() { Id = 3, Name = "Cem Kaya", About = "Deneme", Mail = "cemkaya@blog.com", Password = "000", Status = true }
			);
	}
}
