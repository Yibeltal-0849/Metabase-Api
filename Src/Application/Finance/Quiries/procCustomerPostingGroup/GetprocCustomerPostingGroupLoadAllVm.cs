using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCustomerPostingGroup
{
    public class GetprocCustomerPostingGroupLoadAllVm : IMapFrom<CustomerPostingGroup>
    {

        public string Code { get; set; }
        public string Receivable_Account { get; set; }
        public string Service_Charge_Account { get; set; }
        public string Payment_Disc_Debit_Account { get; set; }
        public string Payment_Disc_Credit_Account { get; set; }
        public string Addtional_Fee_Account { get; set; }
        public string Interest_Account { get; set; }
        public bool? IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CustomerPostingGroup, GetprocCustomerPostingGroupLoadAllVm>();
        }
    }
}
