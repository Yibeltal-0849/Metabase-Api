using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cAccountType.cAccountTypeUpdate.cAccountTypeUpdateCommand
{

	/// @author  Shimels Alem  c_Account_TypeUpdate stored procedure.


	public class cAccountTypeUpdateCommand : IRequest<IList<CAccountType_Id>>
   {
		public long Id { get; set; }
		public string Name { get; set; }
		public int? Catagory { get; set; }
	}
		
		
		 
	}

