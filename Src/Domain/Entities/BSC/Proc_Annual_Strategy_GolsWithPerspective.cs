using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Proc_Annual_Strategy_GolsWithPerspective
    {
        public System.Guid? PerspectiveGoal_ID{ get; set; }
		public string Perspective_ID{ get; set; }
		public string Annual_Strategic_GoalID{ get; set; }
		public double? Perspective_Value_IN_Per{ get; set; }
    }
}
