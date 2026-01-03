using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.KeyPerformanceIndicators
{
    public class GetKeyPerformanceIndicatorsLoadAllVm : IMapFrom<Key_Performance_Indicators>
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

		public void Mapping(Profile profile)
        {
            profile.CreateMap<Key_Performance_Indicators, GetKeyPerformanceIndicatorsLoadAllVm>();
        }
    }
}
