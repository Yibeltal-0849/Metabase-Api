using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procBankAccountPostingGroup
{
    public class GetprocBankAccountPostingGroupLoadAllVm : IMapFrom<BankAccountPostingGroup>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Account_ID { get; set; }
        public string Orgid { get; set; }
        public System.Guid? Branch { get; set; }
        public bool? dufault { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<BankAccountPostingGroup, GetprocBankAccountPostingGroupLoadAllVm>();
        }
    }
}
