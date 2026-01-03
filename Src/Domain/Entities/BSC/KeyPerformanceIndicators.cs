using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Bsc
{
    public class Key_Performance_Indicators
    {
		public Guid KPI_ID { get; set; }
		public string Performance_Indicator { get; set; }
		public string Description { get; set; }
		public string Perspective_ID { get; set; }
		public bool? Update_Interval_Weekly { get; set; }
		public bool? Update_Interval_Monthly { get; set; }
		public bool? Update_Interval_6Monthly { get; set; }
		public string Group_Function { get; set; }
		public string Unit { get; set; }
		public bool? IS_Quantitative { get; set; }
		public bool? Is_Composite { get; set; }
	}
}
