using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cAccountCat.cAccountCatUpdate.cAccountCatUpdateCommand
{

	/// @author  Shimels Alem  c_Account_CatUpdate stored procedure.


	public class cAccountCatUpdateCommand : IRequest<IList<Proc_C_Account_Cat_Code>>
   {
		public int Code { get; set; }
		public string Name { get; set; }
	}
		
		
		 
	}

