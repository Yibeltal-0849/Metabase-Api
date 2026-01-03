using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Quiries.procContract
{
    public class GetprocContractLoadAllVm : IMapFrom<Contract>
    {
        public string Contract_No { get; set; }
        public string Contact_Name { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public System.Guid? DIV { get; set; }
        public string Contract_Type { get; set; }
        public System.Guid? Application_Code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Contract, GetprocContractLoadAllVm>();
        }
    }
}
