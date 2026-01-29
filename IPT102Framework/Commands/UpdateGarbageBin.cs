using IPT102SalinasDomain.Models;
using Repository.Interface;
using Dapper;
using IPT102Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPT102SalinasDomain.Commands;
                                                                                

namespace IPT102Framework.Commands
{
    public class UpdateGarbageBin : IUpdateGarbageBin
    {
        private readonly string _connectionString = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository<GarbageBinModel> _repository;
        public UpdateGarbageBin(
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
