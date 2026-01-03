using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.dbo;
namespace Application.dbo.Queries.procAdjudicated
{
    public class GetprocAdjudicatedLoadAllVm : IMapFrom<Adjudicated>
	{
		public System.Guid? Adjudicated_Code { get; set; }
		public System.Guid? application_code { get; set; }
		public string Plot_ID { get; set; }
		public System.DateTime? Adjudicated_Date { get; set; }
		public string Remark { get; set; }
		public bool? IS_Adjudicated { get; set; }
		public void Mapping(Profile profile)
		{
			profile.CreateMap<Adjudicated, GetprocAdjudicatedLoadAllVm>();
		}
	}
}
