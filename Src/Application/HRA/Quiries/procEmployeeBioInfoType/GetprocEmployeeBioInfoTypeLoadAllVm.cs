using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Quiries.procEmployeeBioInfoType
{
    public class GetprocEmployeeBioInfoTypeLoadAllVm : IMapFrom<EmployeeBioInfoType>
    {
        public string Bio_Type_ID { get; set; }
        public string Name { get; set; }
        public string Json_Meta_Data { get; set; }
        public System.Guid? Visable_For_Task { get; set; }
        public bool? IsActive { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EmployeeBioInfoType, GetprocEmployeeBioInfoTypeLoadAllVm>();
        }
    }
}
