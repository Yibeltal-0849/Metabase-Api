
using System;

namespace XOKA.Domain.Entities.HRA
{
    public class JobPositions1
    {
		public Guid Pos_ID { get; set; }
		public string PositionName { get; set; }
        //public string? department_name { get; set; }
        public Guid? Department_code { get; set; }
        public string JobDescription { get; set; }
        //public string? Leave_type { get; set; }
        public bool? IS_Attendance_Controlled { get; set; }
		public string Parent { get; set; }
    }
}
