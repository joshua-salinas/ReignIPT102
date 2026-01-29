using Dapper;
using System;
using System.Data;

namespace IPT102Framework.Extensions
{
    internal static class StringExtension
    {
        /// <summary>
       
        internal static DynamicParameters ToDynamicParameters(this string? value, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Parameter name must be provided.", nameof(name));

            var parameters = new DynamicParameters();
            parameters.Add($"@{name}", value, DbType.String, ParameterDirection.Input);

            return parameters;
        }
    }
}
