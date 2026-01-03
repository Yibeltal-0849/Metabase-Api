using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cVendorBalance.cVendorBalanceUpdate.cVendorBalanceUpdateCommand
{

	/// @author  Shimels Alem  c_Vendor_BalanceUpdate stored procedure.


	public class cVendorBalanceUpdateCommand : IRequest<IList<CVendor_Vendor_ID>>
   {
        public long Id { get; set; }
        public string Org_id { get; set; }
        public string Vendor_ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Invoice_Number { get; set; }
        public string Purchase_Order_Number { get; set; }
        public decimal? Amount { get; set; }
        public string A_or_R_Account { get; set; }
    }
		
		
		 
}

