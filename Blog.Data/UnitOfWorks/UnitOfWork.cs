using Blog.Data.Context;
using Blog.Data.Repositories.Abstraction;
using Blog.Data.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.UnitOfWorks
{
    internal class UnitOfWork : lUnitOfWork
    {
        private readonly AppDbContext dbContext;
        public UnitOfWork(AppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        
        }

        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();

            
        }

        public int Save()
        {
          return  dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return  await dbContext.SaveChangesAsync();
        }

        lRepository<T> lUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(dbContext);

        }
    }
}
