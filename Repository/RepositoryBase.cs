using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        protected VlsmDb RepositoryContext;

        protected RepositoryBase(VlsmDb repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }


        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? RepositoryContext.Set<T>().AsNoTracking() : RepositoryContext.Set<T>();

        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
    }
}
