using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZenBD_API.Models;

namespace ZenBD_API.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ZenDB context = new ZenDB();
        public void Delete(int id)
        {
            this.context.Set<T>().Remove(Get(id));
            this.context.SaveChanges();
        }

        public T Get(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return this.context.Set<T>().ToList();
        }

        public void Insert(T entity)
        { 
            this.context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
        }
    }
}