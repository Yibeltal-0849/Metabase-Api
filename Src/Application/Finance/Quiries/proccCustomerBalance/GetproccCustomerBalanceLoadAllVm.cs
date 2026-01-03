using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccCustomerBalance
{
    public class GetproccCustomerBalanceLoadAllVm : IMapFrom<CCustomerBalance>
    {
        public long Id { get; set; }
        public string Org_id { get; set; }
        public string Customer_ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Invoice_Number { get; set; }
        public string Purchase_Order_Number { get; set; }
        public decimal? Amount { get; set; }
        public string A_RAccount { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CCustomerBalance, GetproccCustomerBalanceLoadAllVm>();
        }
    }
}
