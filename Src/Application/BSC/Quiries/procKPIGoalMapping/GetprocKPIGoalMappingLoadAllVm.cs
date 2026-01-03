using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.procKPIGoalMapping
{
    public class GetprocKPIGoalMappingLoadAllVm : IMapFrom<KPIGoalMapping>
    {
		public System.Guid KPIMapping_ID { get; set; }
		public System.Guid? KPI_ID { get; set; }
		public string Innitiative_ID { get; set; }
		public Double? BaseLine { get; set; }
		public Double? Target { get; set; }
		public Double? MIN { get; set; }
		public Double? MAX { get; set; }
		public Double? Value { get; set; }
		public Double? Weight { get; set; }
		public Double? Accomplished_Per { get; set; }
		public Double? Varance { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<KPIGoalMapping, GetprocKPIGoalMappingLoadAllVm>();
        }
    }
}
