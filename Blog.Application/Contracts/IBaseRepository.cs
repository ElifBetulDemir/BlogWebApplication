using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Contracts;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    public int Delete(TEntity entity);
    public Task<TEntity> Find(int id);
    public IEnumerable<TEntity> GetAll();
	public Task<TEntity> Insert(TEntity entity);
    public void Update(TEntity entity);
    public Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> filter);
}
