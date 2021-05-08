using LS_Action.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LS_Action.MockData
{
    public class MockMachineData
    {
        public static IEnumerable<Machines> GetMockMachineData()
        {
            var machines = new List<Machines>();

            ///No.1
            machines.Add(new Machines()
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
            });

            ///No.2
            machines.Add(new Machines()
            {
                machineCode = "M00002",
                machineName = "GERBER - Spreader - XLs50",
                lastUpdateAt = DateTime.Now,
                lastUpdateBy = "Admin",
                machineStatus = new MachineStatuses()
                {
                    statusCode = "IS",
                    statusName = "Issue",
                    backgroundColor = "#dc3545",
                    forceColor = "#dc3545",
                    statusIcon = ""
                }
            });

            ///No.3
            machines.Add(new Machines()
            {
                machineCode = "M00003",
                machineName = "GERBER - Spreader - 250s",
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
            });

            ///No.4
            machines.Add(new Machines()
            {
                machineCode = "M00004",
                machineName = "SY 101 Gerber Spreader Machine",
                lastUpdateAt = DateTime.Now,
                lastUpdateBy = "Admin",
                machineStatus = new MachineStatuses()
                {
                    statusCode = "M",
                    statusName = "Maintain",
                    backgroundColor = "#ffc107",
                    forceColor = "#ffc107",
                    statusIcon = ""
                }
            });

            ///No.5
            machines.Add(new Machines()
            {
                machineCode = "M00005",
                machineName = "Band Knife Cutting Machine",
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
            });

            ///No.6
            machines.Add(new Machines()
            {
                machineCode = "M00006",
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
            });

            ///No.7
            machines.Add(new Machines()
            {
                machineCode = "M00007",
                machineName = "GT 7250 Gerber Cutting Machine",
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
            });

            ///No.8
            machines.Add(new Machines()
            {
                machineCode = "M00008",
                machineName = "Rib Cutting Machine, For Industrial",
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
            });

            ///No.9
            machines.Add(new Machines()
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
            });

            ///No.10
            machines.Add(new Machines()
            {
                machineCode = "M00010",
                machineName = "Semi-Automatic CNC Cutting Machine, 15 mm, Metal",
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
            });

            ///No.11
            machines.Add(new Machines()
            {
                machineCode = "M00011",
                machineName = "7.5 Kw Automatic Cutting Machine, For Industrial",
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
            });

            ///No.12
            machines.Add(new Machines()
            {
                machineCode = "M00012",
                machineName = "Spreading Machine",
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
            });

            return machines;
        }
    }
}
