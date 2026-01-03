using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceStatus
{
    public class GetproctblResourceStatusLoadAllVm : IMapFrom<tblResourceStatus>
    {
        public long id { get; set; }
        public string Status { get; set; }
        public bool? Enable { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceStatus, GetproctblResourceStatusLoadAllVm>();
        }
    }
}
