using Dapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Data.SqlClient;
using System.Data;
using OrmBenchMark.Domain;
using System.Linq;
using System.Collections.Generic;

namespace OrmBenchMark.Dapper
{
    public class DapperRepository
    {
        private string ConnectionString { get; set; }

        public DapperRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Customers> ReadAll()
        {
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Customers>("select * from customers").ToList();
            }
        }
    }
}