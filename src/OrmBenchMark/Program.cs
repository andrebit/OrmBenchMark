using System;
using OrmBenchMark.Domain;
using OrmBenchMark.Dapper;

namespace OrmBenchMark
{    
    class Program
    {
        static void Main(string[] args)
        {
            DapperRepository dapperRepository = new DapperRepository("Server=localhost;Database=Northwind;User Id=sa;pwd=1234xxx$@superpwd");
            int total = dapperRepository.ReadAll().Count;
            System.Console.WriteLine($"Total: {total}");
        }
    }
}