using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblAddresses
{
    public class GetproctblAddressesLoadAllVm : IMapFrom<tblAddresses>
    {
		public long? id { get; set; }
		public string Kebele { get; set; }
		public string Fax { get; set; }
		public string Pobox { get; set; }
		public string Email { get; set; }
		public bool? Local_forign { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public long? Woredas_id { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblAddresses, GetproctblAddressesLoadAllVm>();
        }
    }
}
