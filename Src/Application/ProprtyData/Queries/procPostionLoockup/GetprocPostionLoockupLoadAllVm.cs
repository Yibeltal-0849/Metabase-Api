using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.procPostionLoockup
{
    public class GetprocPostionLoockupLoadAllVm : IMapFrom<PostionLoockup>
    {
        public Nullable<System.Guid> Position_ID { get; set; }
        public string description_am { get; set; }
        public string description_en { get; set; }
        public DateTime Created_Date { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PostionLoockup, GetprocPostionLoockupLoadAllVm>();
        }
    }
}
