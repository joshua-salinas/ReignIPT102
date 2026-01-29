using IPT102SalinasDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT102SalinasDomain.Commands
{
     public interface ICreateGarbageBin
    {public Task<bool> ExecuteAsync(GarbageBinModel model);  
    }
}
