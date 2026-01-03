using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceBuyers
{
    public class GetproctblResourceBuyersLoadAllVm : IMapFrom<tblResourceBuyers>
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string FRB_Ownership { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceBuyers, GetproctblResourceBuyersLoadAllVm>();
        }
    }
}
