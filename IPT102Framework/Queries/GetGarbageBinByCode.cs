using Dapper;
using IPT102SalinasDomain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;

namespace IPT102Framework.Queries
{
    public class GetGarbageBinByCode
    {
        private readonly string _connectionString = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository<GarbageBinModel> _repository;

    

        public GetGarbageBinByCode(
        IRepository<GarbageBinModel> repository,
        string storedProcedureName)
        {
            _repository = repository;
            _storedProcedureName = storedProcedureName;
        }

        public async Task<GarbageBinModel> ExecuteAsync(string code)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Code", code, DbType.String);
            return await _repository.ObtainByIdAsync(
                _connectionString,
                _storedProcedureName,
                parameters
            );

                
        }
    }
}
