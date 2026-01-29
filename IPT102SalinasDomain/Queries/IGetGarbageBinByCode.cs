    using System.Threading.Tasks;
    using IPT102SalinasDomain.Models;

    namespace IPT102SalinasDomain.Queries
    {
        /// <summary>
        /// Domain contract for retrieving a garbage bin by its code.
        /// </summary>
        public interface IGetGarbageBinByCode
        {
            Task<GarbageBinModel> ExecuteAsync(string code);
        }
    }
