using System;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using IPT102SalinasDomain.Models;
using Repository.Interface;

namespace IPT102Framework.Queries
{
   
    public class GetGarbageBinId
    {
        private readonly string _connectionString = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository<GarbageBinModel> _repository;

        public GetGarbageBinId(string connectionString, string storedProcedureName, IRepository<GarbageBinModel> repository)
        {
            _connectionString = connectionString;
            _storedProcedureName = storedProcedureName;
            _repository = repository;
        }

        public async Task<GarbageBinModel> ExecuteAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, DbType.Int32);
            return await _repository.ObtainByIdAsync(
                 _connectionString,
                 _storedProcedureName,
                 parameters
            );

        }
    }
}
