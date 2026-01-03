using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCTransactionSales
{
    public class GetprocCTransactionSalesLoadAllVm : IMapFrom<CTransactionSales>
    {

		public string No { get; set; }
		public System.Guid? Org_ID { get; set; }
		public string Type { get; set; }
		public System.Guid? User_id { get; set; }
		public bool? Is_Customer { get; set; }
		public bool? Is_Vendor { get; set; }
		public string Customer_Id { get; set; }
		public string Vendor_ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public System.DateTime? Order_Date { get; set; }
		public System.DateTime? Requested_Delivery_date { get; set; }
		public string Doc_No { get; set; }
		public System.DateTime? Document_Date { get; set; }
		public string Customer_PO { get; set; }
		public string Application_No { get; set; }
		public System.Guid? Application_Code { get; set; }
		public System.Guid? Service_Code { get; set; }
		public string Service_Name { get; set; }
		public System.Guid? Parent_Application_Code { get; set; }
		public string Parent_Application_No { get; set; }
		public string TIN { get; set; }
		public string TAX_Bus_Posting_group { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<CTransactionSales, GetprocCTransactionSalesLoadAllVm>();
        }
    }
}
