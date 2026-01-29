using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPT102SalinasDomain.Models;
using System.Threading.Tasks;

namespace IPT102SalinasDomain.Commands
{
    public interface IUpdateGarbageBin
    {
        Task<bool> ExecuteAsync(GarbageBinModel model);
    }
}
