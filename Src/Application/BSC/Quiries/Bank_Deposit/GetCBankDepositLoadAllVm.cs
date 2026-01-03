using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Quiries.Bank_Deposit
{
    public class GetCBankDepositLoadAllVm : IMapFrom<Proc_C_Bank_Deposit>
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
            profile.CreateMap<Proc_C_Bank_Deposit, GetCBankDepositLoadAllVm>();
        }
    }
}
