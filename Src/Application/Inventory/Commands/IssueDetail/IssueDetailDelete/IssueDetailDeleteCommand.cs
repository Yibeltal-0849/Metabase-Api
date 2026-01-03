 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.IssueDetail.IssueDetailDelete.IssueDetailDeleteCommand
{

    // @author  Shimels Alem  Issue_DetailDelete stored procedure.


    public class IssueDetailDeleteCommand : IRequest<IList<IssueDetail_IssueDetail_ID>>
    {
        public long IssueDetail_ID { get; set; }
    }
		
     
		
		 
	}
 
 