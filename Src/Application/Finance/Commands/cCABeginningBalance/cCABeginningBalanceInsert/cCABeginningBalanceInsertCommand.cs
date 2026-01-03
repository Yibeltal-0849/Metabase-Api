


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cCABeginningBalance.cCABeginningBalanceInsert.cCABeginningBalanceInsertCommand
{

    /// @author  Shimels Alem  c_CA_Beginning_BalanceInsert stored procedure.


    public class cCABeginningBalanceInsertCommand : IRequest<IList<CCaBeginningBalance_Period>>
    {
        public System.DateTime Period { get; set; }
        public string Account_id { get; set; }
        public string Account_Decscrption { get; set; }
        public decimal? Assets_Expense { get; set; }
        public decimal? Liability_Equity_incom { get; set; }
    }
		
		
		 
	}
 
 