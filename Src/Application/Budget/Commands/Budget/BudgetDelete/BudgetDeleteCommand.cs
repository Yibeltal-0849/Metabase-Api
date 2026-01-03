using Application.Budget.Commands.Budget.BudgetInsert.BudgetInsertCommand;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.Budget.BudgetDelete.BudgetDeleteCommand
{

    ///  @author  Shimels Alem  BudgetDelete stored procedure.

    public class BudgetDeleteCommand : IRequest<IList<_Budget_Budget_ID>>
    {
        public long Budget_ID { get; set; }
    }
		
		 
	}
 
 
