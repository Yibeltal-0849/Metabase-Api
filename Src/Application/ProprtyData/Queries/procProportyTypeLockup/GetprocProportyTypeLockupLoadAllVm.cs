using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.procProportyTypeLockup
{
    public class GetprocProportyTypeLockupLoadAllVm : IMapFrom<Proporty_Type_LookUp>
    {
        public int Property_Type_ID { get; set; }
        public string Property_Type { get; set; }
        public int Interval_Month { get; set; }
        public string Static_Json_from { get; set; }
        public string Dinamic_Json_form { get; set; }
        public Nullable<bool> Is_Deleted { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proporty_Type_LookUp, GetprocProportyTypeLockupLoadAllVm>();
        }
    }
}
