using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PTransactionPurchaseType.PTransactionPurchaseTypeUpdate.PTransactionPurchaseTypeUpdateCommand
{

	/// @author  Shimels Alem  [P_Transaction Purchase TypeUpdate] stored procedure.


	public class PTransactionPurchaseTypeUpdateCommand : IRequest<IList<PTransactionPurchaseType_Code>>
   {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Starting_No { get; set; }
        public string Ending_No { get; set; }
        public System.DateTime? Last_Date_Used { get; set; }
        public string Last_No_Used { get; set; }
        public string Default_Nos { get; set; }
        public string Manual_Nos { get; set; }
        public System.DateTime? Date_Order { get; set; }
        public string Pus_Posting_Group { get; set; }
        public System.Guid? Service_Code { get; set; }
    }
		
		
		 
}

