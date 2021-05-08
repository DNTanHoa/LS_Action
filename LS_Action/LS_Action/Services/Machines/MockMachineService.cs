using LS_Action.MockData;
using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LS_Action.Services
{
    public class MockMachineService : IMachineService
    {
        public async Task<Machines> GetMachine(object machineCode)
        {
            var machine = new Machines();

            return machine;
        }

        public async Task<IEnumerable<Machines>> GetMachines()
        {
            return MockMachineData.GetMockMachineData();
        }
    }
}
