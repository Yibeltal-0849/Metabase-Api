using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procADOrgInsert.procADOrgInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_AD_OrgInsert stored procedure.
	 
	#region proc_AD_OrgInsert  
     
  /// proc_AD_OrgInsert stored procedure.
     
        public class procADOrgInsertCommand : IRequest<IList<AdOrg_Code>>
    {
    
		public string code  { get; set; }
		public System.Guid? organization_Code  { get; set; }
		public string name  { get; set; }
		public string address  { get; set; }
		public string country  { get; set; }
		public string telephone  { get; set; }
		public string fax  { get; set; }
		public string tin  { get; set; }
		public string vat  { get; set; }
		public string employerFederal_ID  { get; set; }
		public string employer_Reginal_ID  { get; set; }
		public long? business_Type  { get; set; }
		public string webSite  { get; set; }
		public string email  { get; set; }
		public byte[] logo  { get; set; }
		public long? accounting_Method  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
