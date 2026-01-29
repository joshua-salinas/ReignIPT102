using System;
using System.Threading.Tasks;
using IPT102Framework.Extensions;
using IPT102SalinasDomain.Models;
using Repository.Interface;
using Dapper;
using IPT102SalinasDomain.Commands;


namespace IPT102Framework.Commands
{
    public class CreateGarbageBin : ICreateGarbageBin
    {
        private readonly string _connectionString = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository<GarbageBinModel> _repository;

        public CreateGarbageBin(
            IRepository<GarbageBinModel> repository,
            string storedProcedureName
            )
        {
            _repository = repository;
            _storedProcedureName = storedProcedureName;
        }

        public async Task<bool> ExecuteAsync(GarbageBinModel model)
        {
            var parameters = model.ToGarbageBinDynamicParameters();
            return await _repository.MakeAsync(
                _connectionString,
                _storedProcedureName,
                parameters
                );
        }

    }
}
