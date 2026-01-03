using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procCCustomerInsert.procCCustomerInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_C_CustomerInsert stored procedure.
	 
	#region proc_C_CustomerInsert  
     
  /// proc_C_CustomerInsert stored procedure.
     
        public class procCCustomerInsertCommand : IRequest<IList<CCustomer_Customer_ID>>
    {

		public string Customer_ID { get; set; }
		public string Org_Code { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Website { get; set; }
		public string Postal_code { get; set; }
		public System.Guid? Country { get; set; }
		public string Contact { get; set; }
		public string Sales_Person_code { get; set; }
		public string Telephone_Office { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		public string Sales_Tax_Type { get; set; }
		public bool? Price_Including_VAT { get; set; }
		public double? PrePayment_Per { get; set; }
		public string TIN { get; set; }
		public string Payment_Terms_Code { get; set; }
		public string Payment_Method_code { get; set; }
		public string Fin_Charge_Terms_code { get; set; }
		public System.DateTime? Last_Date_Modified { get; set; }
		public string Last_statement_No { get; set; }
		public double? Credit_Limit { get; set; }
		public string Customer_Posting_Group { get; set; }
		public string Gen_Bus_Posting_Group { get; set; }
		public System.Guid? UserId { get; set; }
	}
		
        #endregion
		
		 
	}
 
 
