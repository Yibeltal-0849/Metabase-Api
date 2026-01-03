using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCBankDeposit
{
    public class GetprocCBankDepositLoadAllVm : IMapFrom<CBankDeposit>
    {
        public string Bank_Name { get; set; }
        public string Vocher_No { get; set; }
        public System.DateTime? Deposit_Ticket_Date { get; set; }
        public string Deposit_Ticket_ID { get; set; }
        public string Amount { get; set; }
        public System.Guid Id { get; set; }
        public System.Guid UserID { get; set; }
        public bool Is_EPayment { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CBankDeposit, GetprocCBankDepositLoadAllVm>();
        }
    }
}
