using CoreProjectAPI.Core.UnitOfWork;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace CoreProjectAPI.Application.UoW
{
    public class DapperUnitOfWork : IDapperUnitOfWork
    {

        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private IsolationLevel _isolationLevel;
        private readonly IConfiguration _configuration;

        public IDbConnection Connection
        {
            get
            {
                return _connection;
            }
            private set
            {
                _connection = value;
            }
        }

        public IDbTransaction Transaction
        {
            get
            {
                return _transaction;
            }
            private set
            {
                _transaction = value;
            }
        }

        public IsolationLevel IsolationLevel
        {
            get
            {
                return _isolationLevel;
            }
            set
            {
                _isolationLevel = value;
            }
        }


        public DapperUnitOfWork(IConfiguration configuration, IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            _isolationLevel = isolationLevel;
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("SqlConnectionString"));
            _connection.Open();
        }

        public void Commit()
        {

        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
