﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LS_Action.Models
{
    public class Issue
    {
        public int issueId { get; set; }
        public string issueDescription { get; set; }
        public IssueStatuses issueStatus { get; set; }
        
        #region Sync Properties
        public DateTime lastUpdateAt { get; set; }
        public string lastUpdateBy { get; set; }
        #endregion
    }
}
