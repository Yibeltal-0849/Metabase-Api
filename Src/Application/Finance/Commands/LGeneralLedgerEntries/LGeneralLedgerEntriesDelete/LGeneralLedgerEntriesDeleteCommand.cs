 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.Finance.Commands.LGeneralLedgerEntries.LGeneralLedgerEntriesDelete.LGeneralLedgerEntriesDeleteCommand
{

    // @author  Shimels Alem  LGeneralLedgerEntriesDelete stored procedure.


    public class LGeneralLedgerEntriesDeleteCommand : IRequest<IList<Proc_LGeneralLedgerEntries_Code>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public string Document_Type { get; set; }
        public string Document_No { get; set; }
    }
		
     
		
		 
	}
 
 