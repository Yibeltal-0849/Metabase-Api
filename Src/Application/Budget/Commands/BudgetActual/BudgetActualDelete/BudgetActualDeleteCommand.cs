using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetActual.BudgetActualDelete.BudgetActualDeleteCommand
{

    ///  @author Shimels Alem  Budget_ActualDelete stored procedure.

    public class BudgetActualDeleteCommand : IRequest<IList<Budget_Actual_Budget_ActualID>>
    {
        public long Budget_ActualID { get; set; }
    }
		
		 
	}
 
 
