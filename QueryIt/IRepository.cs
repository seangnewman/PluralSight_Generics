using System;

namespace QueryIt
{
    public interface IRepository<T> : IReadOnlyRepository<T>, IWriteOnlyRepository<T>, IDisposable
    {

        // CRUD functionality
      
    }
}
