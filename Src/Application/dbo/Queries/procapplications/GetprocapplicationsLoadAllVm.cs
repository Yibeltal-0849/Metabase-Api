using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Quiries.procapplications
{
    public class GetprocapplicationsLoadAllVm : IMapFrom<applications>
    {
		public System.Guid application_code { get; set; }
		public string application_number { get; set; }
		public int? is_completed { get; set; }
		public string status { get; set; }
		public int? rollback_count { get; set; }
		public System.DateTime? date_created { get; set; }
		public string date_created_et { get; set; }
		public System.Guid? UserId { get; set; }
		public System.Guid? services_service_code { get; set; }
		public bool? is_synched { get; set; }
		public System.DateTime? date_synched { get; set; }
		public System.Guid? organization_code { get; set; }
		public long? QueueNo { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<applications, GetprocapplicationsLoadAllVm>();
        }
    }
}
