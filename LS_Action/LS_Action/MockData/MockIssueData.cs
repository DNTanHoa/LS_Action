using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS_Action.MockData
{
    public class MockIssueData
    {
        public MockIssueData()
        {
            this.Issues = new List<Issue>();

            this.Issues.Add(new Issue()
            {
                issueId = 1,
                issueDescription = "Dao cắt lệch hướng",
                issueStatus = new IssueStatuses()
                {
                    statusCode = "O",
                    statusName = "Open",
                    backgroundColor = "#dc3545",
                    forceColor = "white"
                },
                machine = new Machines()
                {
                    machineCode = "M00009",
                    machineName = "Cpu With Monitor 3 Phase Gerber Auto cutter, Model Name/Number: Gt -7250, Machine Blade Size: 7 Cm Cutting Height",
                    lastUpdateAt = DateTime.Now,
                    lastUpdateBy = "Admin",
                    machineStatus = new MachineStatuses()
                    {
                        statusCode = "A",
                        statusName = "Active",
                        backgroundColor = "#28a745",
                        forceColor = "#28a745",
                        statusIcon = ""
                    }
                },
                createBy = "Admin",
                createAt = DateTime.Now,
                lastUpdateAt = DateTime.Now,
                lastUpdateBy = "User"
            });

            this.Issues.Add(new Issue()
            {
                issueId = 2,
                issueDescription = "Đường may bị bỏ mũi",
                issueStatus = new IssueStatuses()
                {
                    statusCode = "O",
                    statusName = "Done",
                    backgroundColor = "#28a745",
                    forceColor = "white"
                },
                machine = new Machines()
                {
                    machineCode = "M00001",
                    machineName = "Solac SW8230 - Sewing Machine - 16 stitch types",
                    lastUpdateAt = DateTime.Now,
                    lastUpdateBy = "Admin",
                    machineStatus = new MachineStatuses()
                    {
                        statusCode = "A",
                        statusName = "Active",
                        backgroundColor = "#28a745",
                        forceColor = "#28a745",
                        statusIcon = ""
                    }
                },
                createBy = "Admin",
                createAt = DateTime.Now,
                lastUpdateAt = DateTime.Now,
                lastUpdateBy = "User"
            });

            this.Issues.Add(new Issue()
            {
                issueId = 3,
                issueDescription = "Rối chỉ khi bắt đầu may",
                issueStatus = new IssueStatuses()
                {
                    statusCode = "O",
                    statusName = "Pending",
                    backgroundColor = "#ffc107",
                    forceColor = "white"
                },
                machine = new Machines()
                {
                    machineCode = "M00001",
                    machineName = "Solac SW8230 - Sewing Machine - 16 stitch types",
                    lastUpdateAt = DateTime.Now,
                    lastUpdateBy = "Admin",
                    machineStatus = new MachineStatuses()
                    {
                        statusCode = "A",
                        statusName = "Active",
                        backgroundColor = "#28a745",
                        forceColor = "#28a745",
                        statusIcon = ""
                    }
                },
                createBy = "Admin",
                createAt = DateTime.Now,
                lastUpdateAt = DateTime.Now,
                lastUpdateBy = "User"
            });

            this.Issues.Add(new Issue()
            {
                issueId = 4,
                issueDescription = "Dao cắt lệch hướng",
                issueStatus = new IssueStatuses()
                {
                    statusCode = "O",
                    statusName = "Open",
                    backgroundColor = "#dc3545",
                    forceColor = "white"
                },
                machine = new Machines()
                {
                    machineCode = "M00009",
                    machineName = "Cpu With Monitor 3 Phase Gerber Auto cutter, Model Name/Number: Gt -7250, Machine Blade Size: 7 Cm Cutting Height",
                    lastUpdateAt = DateTime.Now,
                    lastUpdateBy = "Admin",
                    machineStatus = new MachineStatuses()
                    {
                        statusCode = "A",
                        statusName = "Active",
                        backgroundColor = "#28a745",
                        forceColor = "#28a745",
                        statusIcon = ""
                    }
                },
                createBy = "Admin",
                createAt = DateTime.Now,
                lastUpdateAt = DateTime.Now,
                lastUpdateBy = "User"
            });

            this.Issues.Add(new Issue()
            {
                issueId = 5,
                issueDescription = "Đường may bị bỏ mũi",
                issueStatus = new IssueStatuses()
                {
                    statusCode = "O",
                    statusName = "Done",
                    backgroundColor = "#28a745",
                    forceColor = "white"
                },
                machine = new Machines()
                {
                    machineCode = "M00001",
                    machineName = "Solac SW8230 - Sewing Machine - 16 stitch types",
                    lastUpdateAt = DateTime.Now,
                    lastUpdateBy = "Admin",
                    machineStatus = new MachineStatuses()
                    {
                        statusCode = "A",
                        statusName = "Active",
                        backgroundColor = "#28a745",
                        forceColor = "#28a745",
                        statusIcon = ""
                    }
                },
                createBy = "Admin",
                createAt = DateTime.Now,
                lastUpdateAt = DateTime.Now,
                lastUpdateBy = "User"
            });

            this.Issues.Add(new Issue()
            {
                issueId = 6,
                issueDescription = "Rối chỉ khi bắt đầu may",
                issueStatus = new IssueStatuses()
                {
                    statusCode = "O",
                    statusName = "Pending",
                    backgroundColor = "#ffc107",
                    forceColor = "white"
                },
                machine = new Machines()
                {
                    machineCode = "M00001",
                    machineName = "Solac SW8230 - Sewing Machine - 16 stitch types",
                    lastUpdateAt = DateTime.Now,
                    lastUpdateBy = "Admin",
                    machineStatus = new MachineStatuses()
                    {
                        statusCode = "A",
                        statusName = "Active",
                        backgroundColor = "#28a745",
                        forceColor = "#28a745",
                        statusIcon = ""
                    }
                },
                createBy = "Admin",
                createAt = DateTime.Now,
                lastUpdateAt = DateTime.Now,
                lastUpdateBy = "User"
            });
        }
        public List<Issue> Issues { get; set; }
    }
}
