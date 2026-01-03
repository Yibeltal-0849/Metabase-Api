using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.ProcorganizationType
{
    public class GetProcorganizationTypeLoadAllVm : IMapFrom<organization_Type>
    {
        public System.Guid organization_Type_Code { get; set; }
        public string description_En { get; set; }
        public string description_Am { get; set; }
        public string description_Or { get; set; }
        public string description_Tg { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<organization_Type, GetProcorganizationTypeLoadAllVm>();
        }
    }
}
