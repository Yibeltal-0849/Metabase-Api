using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.ContractType
{
    public class GetprocContractTypeLoadAllVm : IMapFrom<ContractTypeD>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Numbering { get; set; }
        public string Last_Numbering_used { get; set; }
        public System.DateTime Last_Numbering_Date { get; set; }
        public bool IsActive { get; set; }
        public System.Guid Organization_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ContractTypeD, GetprocContractTypeLoadAllVm>();
        }
    }
}
