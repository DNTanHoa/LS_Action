using System;
using System.Collections.Generic;
using System.Text;

namespace LS_Action.Models
{
    public class Machines
    {
        public string machineCode { get; set; }
        public string machineName { get; set; }
        public MachineStatuses machineStatus { get; set; }
        
        #region Sync Properties
        public DateTime lastUpdateAt { get; set; }
        public string lastUpdateBy { get; set; }
        #endregion
    }
}
