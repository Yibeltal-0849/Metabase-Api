using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPJobLineType.procPJobLineTypeUpdate.procPJobLineTypeUpdateCommand
{

	/// @author  Shimels Alem  proc_P_Job_Line_TypeUpdate stored procedure.


	public class procPJobLineTypeUpdateCommand : IRequest<IList<PJobLineType_Code>>
   {
		public string Code { get; set; }
		public bool? IsActive { get; set; }
	}
		
		
		 
}

