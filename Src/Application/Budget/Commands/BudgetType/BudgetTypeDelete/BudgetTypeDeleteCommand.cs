using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetType.BudgetTypeDelete.BudgetTypeDeleteCommand
{

    ///   @author Shimels Alem Budget_TypeDelete stored procedure.

    public class BudgetTypeDeleteCommand : IRequest<IList<Budget_Type_Code>>
    {
        public string Code { get; set; }
    }
		
		 
	}
 
 
