using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetDetailByDIV.BudgetDetailByDIVDelete.BudgetDetailByDIVDeleteCommand
{

    ///   @author Shimels Alem Budget_DetailByDIVDelete stored procedure.

    public class BudgetDetailByDIVDeleteCommand : IRequest<IList<Budget_DetailByDiv_Budget_DetailID>>
    {
        public string Budget_DetailID { get; set; }
    }
		
		 
	}
 
 
