using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.BudgetDetailByDIV.BudgetDetailByDIVInsert.BudgetDetailByDIVInsertCommand
{

    ///   @author Shimels Alem Budget_DetailByDIVInsert stored procedure.

    public class BudgetDetailByDIVInsertCommand : IRequest<IList<Budget_DetailByDiv_Budget_DetailID>>
    {
		public string Budget_DetailID { get; set; }
		public long Budget_ID { get; set; }
		public string Budget_Type { get; set; }
		public System.Guid DIV_code { get; set; }
		public string Unit { get; set; }
		public System.Guid? ParentBuget_Detail_ID { get; set; }
		public string Description { get; set; }
		public bool? Is_Approved { get; set; }
		public System.Double? Budget_Ammount_Birr { get; set; }
		public System.Guid? ApplicationCode { get; set; }
		public string Application_NO { get; set; }
		public string DocNo { get; set; }
		public string Innitiative_ID { get; set; }
		public System.Guid? Budget_Allocation_Type { get; set; }
		public string Log { get; set; }
	}
		
		 
}
 
 
