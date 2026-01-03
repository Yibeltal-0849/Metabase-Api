using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.ProcProportyStaticData
{
    public class GetProcProportyStaticDataLoadAllVm : IMapFrom<Proporty_Static_Data>
    {
        public System.Guid ID { get; set; }
        public string Property_ID { get; set; }
        public string Static_form_Data { get; set; }
        public Nullable<System.DateTime> Collection_Date { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proporty_Static_Data, GetProcProportyStaticDataLoadAllVm>();
        }
    }
}
