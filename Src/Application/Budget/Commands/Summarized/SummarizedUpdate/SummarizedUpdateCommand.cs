using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.Summarized.SummarizedUpdate.SummarizedUpdateCommand
{

    ///   @author Shimels Alem SummarizedUpdate stored procedure.

    public class SummarizedUpdateCommand : IRequest<IList<_Summarized_Budget_Summarized_ID>>
    {
        public Guid Budget_Summarized_ID { get; set; }
        public Int64 Budget_ID { get; set; }
        public string Budget_Type { get; set; }
        public Guid organization_code { get; set; }
        public Guid? ParentBuget_Sum_ID { get; set; }
        public string Unit { get; set; }
        public bool? Is_Approved { get; set; }
        public long? Budget_Ammount_Birr { get; set; }
        public Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public string DocNo { get; set; }
        public string Log { get; set; }

    }
		
		 
	}
 
 
