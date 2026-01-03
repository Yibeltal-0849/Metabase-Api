using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procFixedAssetRent
{
    public class GetprocFixedAssetRentLoadAllVm : IMapFrom<FixedAssetRent>
    {
		public long Rent_ID { get; set; }
		public long Item_ID { get; set; }
		public string Fixed_Asset_Type { get; set; }
		public string Contract_No { get; set; }
		public System.DateTime? Rent_Start_Date { get; set; }
		public System.DateTime? Rent_End_Date { get; set; }
		public System.Double? Rent_Value { get; set; }
		public System.Double? VAT { get; set; }
		public System.Double? Total_RentValue { get; set; }
		public string Reference_Number { get; set; }
		public string Payment_Mode { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<FixedAssetRent, GetprocFixedAssetRentLoadAllVm>();
        }
    }
}
