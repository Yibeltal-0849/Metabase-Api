using System;

namespace XOKA.Domain.Entities.HRA
{
    public class AttendanceLog
    {
        public string? Name { get; set; }
        public DateTime PunchDateTime { get; set; }
        public string? ModeDescription { get; set; }
        public int MachineID { get; set; }
    }
}
