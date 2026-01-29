using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repository.Interface
{
    public interface IRepository<J>
    {
        Task<IEnumerable<J>> ObtainAllAsync(
            string connectionString,
            string storedProcedureName,
            DynamicParameters parameters
            );

        Task<J> ObtainByIdAsync(
            string connectionString,
            string storedProcedureName,
            DynamicParameters parameters
            );

        Task<bool> MakeAsync(
            string connectionString,
            string storedProcedureName,
            DynamicParameters parameters
            );

        Task<bool> UpdateAsync(
            string connectionString,
            string storedProcedureName,
            DynamicParameters parameters
            );

        Task<bool> RemoveAsync(
            string connectionString,
            string procedureName,
            DynamicParameters parameters
            );
        
    }
}
