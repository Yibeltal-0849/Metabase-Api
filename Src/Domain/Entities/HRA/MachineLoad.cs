using System;
namespace XOKA.Domain.Entities.HRA
{
    public class MachineLoad
    {
        public int MachineID { get; set; }
        public string OrgCode { get; set; }
        public int? Status { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
