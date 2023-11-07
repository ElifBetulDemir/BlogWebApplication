using Blog.Application.Contracts;
using Blog.Entities.Abstract;
using Blog.Entities.Concrete;
using Blog.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly BlogContext context;
    public BaseRepository(BlogContext context)
    {
        this.context = context;
    }

    public async Task<TEntity> Find(int id)
    {
        return await context.Set<TEntity>().FindAsync(id);
    }

    public int Delete(TEntity entity)
    {
        entity.Status = false;
        return context.SaveChanges();
    }

    public IEnumerable<TEntity> GetAll()
    {
        return context.Set<TEntity>().Where(x => x.Status == true).ToList();
    }

    public async Task<TEntity> Insert(TEntity entity)
    {
        await context.Set<TEntity>().AddAsync(entity);
        await context.SaveChangesAsync();

        return entity;
    }

    public void Update(TEntity entity)
    {
        context.Entry(entity).State = EntityState.Modified;
        context.SaveChanges();
    }

    public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> filter)
    {
        return await context.Set<TEntity>().Where(filter).ToListAsync();
    }
}
