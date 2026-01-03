using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procDocument_Type
{
    public class GetprocDocument_TypeLoadAllVm : IMapFrom<DocumentType>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Is_Active { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<DocumentType, GetprocDocument_TypeLoadAllVm>();
        }
    }
}
