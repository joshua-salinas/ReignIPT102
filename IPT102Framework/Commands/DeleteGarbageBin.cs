using Dapper;
using IPT102SalinasDomain.Commands;
using IPT102SalinasDomain.Models;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT102Framework.Commands
{
    public class DeleteGarbageBin : IDeleteGarbageBin
    {

        private readonly string _connectionString = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository<GarbageBinModel> _repository;

        public DeleteGarbageBin(
            IRepository<GarbageBinModel> repository,
            string storedProcedureName
            )
        {
            _repository = repository;
            _storedProcedureName = storedProcedureName;
        }


        public async Task<bool> ExecuteAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            return await _repository.MakeAsync(
                _connectionString,
                _storedProcedureName,
                parameters
                );
        }

    }
}