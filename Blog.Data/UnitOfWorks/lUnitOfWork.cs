using Blog.Core.Entities;
using Blog.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.UnitOfWorks
{
    public interface lUnitOfWork : IAsyncDisposable
    {
        lRepository<T> GetRepository<T>() where T : class, lEntityBase, new ();

        Task<int> SaveAsync();
        int Save();
    }

}
