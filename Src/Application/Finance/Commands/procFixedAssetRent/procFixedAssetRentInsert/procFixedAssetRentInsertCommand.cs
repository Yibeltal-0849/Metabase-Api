


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFixedAssetRent.procFixedAssetRentInsert.procFixedAssetRentInsertCommand
{

	/// @author  Shimels Alem  proc_Fixed_Asset_RentInsert stored procedure.


	public class procFixedAssetRentInsertCommand : IRequest<IList<FixedAssetRent_Rent_ID>>
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
	}
		
		
		 
}
 
 