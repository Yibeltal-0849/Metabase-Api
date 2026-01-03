using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cPayType.cPayTypeUpdate.cPayTypeUpdateCommand
{

	/// @author  Shimels Alem  c_PayTypeUpdate stored procedure.


	public class cPayTypeUpdateCommand : IRequest<IList<CPayType_PayType>>
   {
		public string PayType { get; set; }
		public string GL_Account_Number { get; set; }
		public string OrgCode { get; set; }
	}
		
		
		 
}

