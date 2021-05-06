using System;
using System.Collections.Generic;
using System.Text;

namespace LS_Action.Model.Models
{
    public class ProblemAttach
    {
        public int id { get; set; }
        public Problem problem { get; set; }
        public string type { get; set; }
        public string attachPath { get; set; }
    }
}
