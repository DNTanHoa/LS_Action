using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LS_Action.Services
{
    public interface IIssueService
    {
        Task<IEnumerable<Issue>> GetIssues();
        Task<Issue> GetIssue(int id);
    }
}
