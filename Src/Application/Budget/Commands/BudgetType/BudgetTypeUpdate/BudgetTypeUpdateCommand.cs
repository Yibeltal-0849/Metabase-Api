using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetType.BudgetTypeUpdate.BudgetTypeUpdateCommand
{

    ///   @author Shimels Alem Budget_TypeUpdate stored procedure.

    public class BudgetTypeUpdateCommand : IRequest<IList<Budget_Type_Code>>
    {
        public string Code { get; set; }
        public string Expenditure { get; set; }
        public string Description { get; set; }
        public string AccountCode { get; set; }
        public string Parent { get; set; }
        public Guid? For_organization { get; set; }
        public bool? Is_Account { get; set; }
    }
		
		 
	}
 
 
