


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cLedger.cLedgerInsert.cLedgerInsertCommand
{

    /// @author  Shimels Alem  c_LedgerInsert stored procedure.


    public class cLedgerInsertCommand : IRequest<IList<CLedger_Period_ID>>
    {
        public System.DateTime Period_ID { get; set; }
        public string Account_ID { get; set; }
        public string Narration { get; set; }
        public double? Amount { get; set; }
    }
		
		
		 
}
 
 