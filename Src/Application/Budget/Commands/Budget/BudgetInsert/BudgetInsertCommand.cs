using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.Budget.BudgetInsert.BudgetInsertCommand
{

    ///    @author Shimels Alem  BudgetInsert stored procedure.

    public class BudgetInsertCommand : IRequest<IList<_Budget_Budget_ID>>
    {
        public long? Budget_ID { get; set; }
        public Guid? organization_code { get; set; }
        public int? Year { get; set; }
        public double? Total_Budget_Amount_In_Birr { get; set; }
        public Guid? StatusType { get; set; }
        public Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public string DocNo { get; set; }
        public string Log { get; set; }
    }
		
		 
	}
 
 
