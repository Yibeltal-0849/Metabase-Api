


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.IssueDetail.IssueDetailInsert.IssueDetailInsertCommand
{

    /// @author  Shimels Alem  Issue_DetailInsert stored procedure.


    public class IssueDetailInsertCommand : IRequest<IList<IssueDetail_IssueDetail_ID>>
    {
        public long? IssueDetail_ID { get; set; }
        public System.Guid? Issue_ID { get; set; }
        public string Item_ID { get; set; }
        public double? Issue_Quantity { get; set; }
        public double? Unit_Value { get; set; }
        public double? Total_Value { get; set; }
        public System.Guid? Recived_By { get; set; }
        public string Remark { get; set; }
        public string Log { get; set; }
    }
		
		
		 
	}
 
 