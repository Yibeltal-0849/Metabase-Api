using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.IssueDetail.IssueDetailUpdate.IssueDetailUpdateCommand
{

	/// @author  Shimels Alem  Issue_DetailUpdate stored procedure.


	public class IssueDetailUpdateCommand : IRequest<IList<IssueDetail_IssueDetail_ID>>
    {
        public long IssueDetail_ID { get; set; }
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

