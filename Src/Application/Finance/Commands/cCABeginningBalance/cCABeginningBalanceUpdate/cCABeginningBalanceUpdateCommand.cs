using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cCABeginningBalance.cCABeginningBalanceUpdate.cCABeginningBalanceUpdateCommand
{

	/// @author  Shimels Alem  c_CA_Beginning_BalanceUpdate stored procedure.


	public class cCABeginningBalanceUpdateCommand : IRequest<IList<CCaBeginningBalance_Period>>
    {
        public System.DateTime Period { get; set; }
        public string Account_id { get; set; }
        public string Account_Decscrption { get; set; }
        public decimal? Assets_Expense { get; set; }
        public decimal? Liability_Equity_incom { get; set; }
    }
		
		
		 
	}

