using LS_Action.MockData;
using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS_Action.Services
{
    public class MockIssueService : IIssueService
    {
        MockIssueData mockData { get; set; }
        public MockIssueService()
        {
            mockData = new MockIssueData();
        }
        public async Task<Issue> GetIssue(int id)
        {
            return mockData.Issues.FirstOrDefault(x => x.issueId == id);
        }

        public async Task<IEnumerable<Issue>> GetIssues()
        {
            return mockData.Issues;
        }
    }
}
