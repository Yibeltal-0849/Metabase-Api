using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.procContractPaymentTerm
{
    public class GetprocContractPaymentTermLoadAllVm : IMapFrom<ContractPaymentTerm>
    {
        public System.Guid Payment_TermID { get; set; }
        public string Payment_Term { get; set; }
        public string Declaration { get; set; }
        public bool? Is_Approved { get; set; }
        public string ContractID { get; set; }
        public double? Percent { get; set; }
        public double? Total_Percent { get; set; }
        public string? Parent { get; set; }
        public string? description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ContractPaymentTerm, GetprocContractPaymentTermLoadAllVm>();
        }
    }
}
