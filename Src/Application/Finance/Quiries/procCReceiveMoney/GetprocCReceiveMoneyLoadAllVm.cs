using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCReceiveMoney
{
    public class GetprocCReceiveMoneyLoadAllVm : IMapFrom<CReceiveMoney>
    {

        public string Deposit_TicketID { get; set; }
        public string Reference { get; set; }
        public string Receipt_Number { get; set; }
        public string InvouceID { get; set; }
        public bool? ISCustomer { get; set; }
        public string CustomerID { get; set; }
        public string Vendor_ID { get; set; }
        public decimal? Receipt_Amount { get; set; }
        public long? Payment_Method { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CReceiveMoney, GetprocCReceiveMoneyLoadAllVm>();
        }
    }
}
