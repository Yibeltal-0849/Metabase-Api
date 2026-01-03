using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.procProportyAndPostion
{
    public class GetprocProportyAndPostionLoadAllVm : IMapFrom<Proporty_And_Postion>
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> Position_ID { get; set; }
        public string Property_ID { get; set; }
        public Nullable<int> Priority { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proporty_And_Postion, GetprocProportyAndPostionLoadAllVm>();
        }
    }
}
