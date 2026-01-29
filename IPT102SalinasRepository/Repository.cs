using Dapper;
using Microsoft.Data.SqlClient;
using Repository.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT102SalinasRepository
{
    public class  Repository<J> : IRepository<J>
    {
        private SqlConnection CreateConnection(string connectionString)
        => new SqlConnection(connectionString);

        public async Task<IEnumerable<J>> ObtainAllAsync(
            string connectionString,
            string storedProcedureName,
            DynamicParameters parameters = null
            )
        {
            using var connection = CreateConnection(connectionString);
            return await connection.QueryAsync<J>(
                storedProcedureName,
                parameters,
                commandType: System.Data.CommandType.StoredProcedure
                );
        }

        public async Task<J> ObtainByIdAsync(
            string connectionString,
            string storedProcedureName,
            DynamicParameters parameters = null
            )

        {
            using var connection = CreateConnection(connectionString);
            return await connection.QueryFirstOrDefault
                (
                storedProcedureName,
                parameters,
                commandType: System.Data.CommandType.StoredProcedure
                );
        }

        public async Task<bool> MakeAsync(
            string connectionString,
            string storedProcedureName,
            DynamicParameters parameters = null
            )

        {
            using var connection = CreateConnection(connectionString);
            var result = await connection.ExecuteAsync(
                storedProcedureName,
                parameters,
                commandType: System.Data.CommandType.StoredProcedure
                );
            return result > 0;
        }

        public async Task<bool> UpdateAsync(
            string connectionString,
            string storedProcedureName,
            DynamicParameters parameters = null
            )

        {
            using var connection = CreateConnection(connectionString);
            var result = await connection.ExecuteAsync(
                storedProcedureName,
                parameters,
                commandType: System.Data.CommandType.StoredProcedure
                );

            return result > 0;
        }

        public async Task<bool> RemoveAsync(
             string connectionString,
             string procedureName,
             DynamicParameters parameters = null
             )

        {
            using var connection = CreateConnection(connectionString);
            var result = await connection.ExecuteAsync(
                procedureName,
                parameters,
                commandType: System.Data.CommandType.StoredProcedure
                );

            return result > 0;
        }

    }
}
