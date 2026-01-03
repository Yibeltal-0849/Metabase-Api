using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procServiceProviders
{
    public class GetprocServiceProvidersLoadAllVm : IMapFrom<Service_Providers>
    {
		public string service_provider_code { get; set; }
		public string workflow_code { get; set; }
		public string organization_code { get; set; }
		public string service_owner_code { get; set; }
		public string Created_By { get; set; }
		public string Date_Created { get; set; }
		public string Is_Active { get; set; }
		public string department_en { get; set; }
		public string department_am { get; set; }
		public string department_or { get; set; }
		public string department_tg { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<Service_Providers, GetprocServiceProvidersLoadAllVm>();
        }
    }
}
