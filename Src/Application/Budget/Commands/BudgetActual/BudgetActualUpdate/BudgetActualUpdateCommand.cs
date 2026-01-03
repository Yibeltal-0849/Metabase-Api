using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetActual.BudgetActualUpdate.BudgetActualUpdateCommand
{

    ///   @author Shimels Alem Budget_ActualUpdate stored procedure.

    public class BudgetActualUpdateCommand : IRequest<IList<Budget_Actual_Budget_ActualID>>
    {
        public long Budget_ActualID { get; set; }
        public string Budget_DetailID { get; set; }
        public string Account_ID { get; set; }
        public double? Actual_Cost { get; set; }

    }
		
		 
}
 
 
