using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procRentCollectionRequestFromBankInsert
{
    public class GetRentCollectionRequestFromBankLoadAllVm : IMapFrom<RentCollectionRequestFromBank>
    {
		public string Application_NO { get; set; }
		public string Referance_Number { get; set; }
		public double Amount { get; set; }
		public string Currency { get; set; }
		public System.DateTime? @RequestDate { get; set; }
		public bool Is_Paid { get; set; }
		public System.DateTime? Paid_Date { get; set; }
		public string PayTicket_NO { get; set; }
		public System.DateTime? TimeStamp { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<RentCollectionRequestFromBank, GetRentCollectionRequestFromBankLoadAllVm>();
        }
    }
}
