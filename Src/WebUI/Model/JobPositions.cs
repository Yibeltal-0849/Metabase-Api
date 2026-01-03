using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOKA.WebUI.Model
{
	public class JobPositions
	{
		public Guid? Pos_ID { get; set; }
		public string PositionName { get; set; }
		public Guid? Department_code { get; set; }
		public string JobDescription { get; set; }
		public bool? IS_Attendance_Controlled { get; set; }
        public string Parent { get; set; }
        public bool? Is_Active { get; set; }
    }
}
