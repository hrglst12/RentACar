using System;
using System.Data;

namespace CoreProjectAPI.Core.UnitOfWork
{
    public interface IDapperUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        IsolationLevel IsolationLevel { get; }
        void Commit();
    }
}
