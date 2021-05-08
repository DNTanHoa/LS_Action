using System;
using System.Collections.Generic;
using System.Text;

namespace LS_Action.Models
{
    public class IssueActivityLog
    {
        public int activityId { get; set; }
        public Issue issue { get; set; }
        public string comment { get; set; }
        public IssueStatuses issueStatus { get; set; }

        #region Sync Properties
        public DateTime lastUpdateAt { get; set; }
        public string lastUpdateBy { get; set; }
        #endregion
    }
}
