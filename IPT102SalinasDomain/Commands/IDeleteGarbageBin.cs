using System.Threading.Tasks;

namespace IPT102SalinasDomain.Commands
{
    /// <summary>
    /// Domain contract for deleting a garbage bin.
    /// </summary>
    public interface IDeleteGarbageBin
    {
        Task<bool> ExecuteAsync(int id);
    }
}
