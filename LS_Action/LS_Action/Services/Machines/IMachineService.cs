using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LS_Action.Services
{
    public interface IMachineService
    {
        Task<IEnumerable<Machines>> GetMachines();
        Task<Machines> GetMachine(object machineCode);
    }
}
