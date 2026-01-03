using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.Summarized.SummarizedDelete.SummarizedDeleteCommand
{

    ///   @author Shimels Alem SummarizedDelete stored procedure.

    public class SummarizedDeleteCommand : IRequest<IList<_Summarized_Budget_Summarized_ID>>
    {
        public Guid Budget_Summarized_ID { get; set; }
        public Int64 Budget_ID { get; set; }
        public string Budget_Type { get; set; }
        public Guid organization_code { get; set; }
    }
		
		 
	}
 
 
