using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample_exam.Entities;
using System.Linq.Expressions;

namespace Sample_exam.DataAccess
{
    public abstract class BaseRepository<T>
       where T : BaseEntity
    {
        protected DbContext Context { get; set; }
        protected DbSet<T> Items { get; set; }

        public BaseRepository()
        {
            Context = new MyDbContext();
            Items = Context.Set<T>();
        }

        public void Insert(T item)
        {
            Items.Add(item);
            Context.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = Items;

            if (filter != null)
                query = query.Where(filter);

            return query.ToList();
        }

        public T GetById(int id)
        {
            IQueryable<T> query = Items;
            return query
                    .Where(i => i.Id == id)
                    .FirstOrDefault();
        }

        public void Update(T item)
        {
            Items.Update(item);
            Context.SaveChanges();
        }

        public void Delete(T item)
        {
            Items.Remove(item);
            Context.SaveChanges();
        }

    }


}