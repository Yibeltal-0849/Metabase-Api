using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procEmplyeeBio
{
    public class GetprocEmplyeeBioLoadAllVm : IMapFrom<EmplyeeBio>
    {
        public System.Guid Emp_Bio { get; set; }
        public string Employee_ID { get; set; }
        public string Bio_Type { get; set; }
        public string Json_Bio_Data { get; set; }
        public string Json_Log { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EmplyeeBio, GetprocEmplyeeBioLoadAllVm>();
        }
    }
}
