using Dapper;
using IPT102SalinasDomain.Models;
using System;
using System.Data;

namespace IPT102Framework.Extensions
{
    public static class GarbageBinExtension
    {
        public static DynamicParameters ToGarbageBinDynamicParameters(this GarbageBinModel model)
        {
            if (model is null)
                throw new ArgumentNullException(nameof(model));

            var parameters = new DynamicParameters();

            parameters.Add("@Id", model.Id, DbType.String, ParameterDirection.Input);
            parameters.Add("@BinCode", model.BinCode, DbType.String, ParameterDirection.Input);
            parameters.Add("@Location", model.Location, DbType.String, ParameterDirection.Input);
            parameters.Add("@Capacity", model.Capacity, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("@Status", model.Status, DbType.String, ParameterDirection.Input);

            return parameters;
        }
    }
}
