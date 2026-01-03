using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CCurrencyID.CCurrencyIDUpdate.CCurrencyIDUpdateCommand
{

	/// @author  Shimels Alem  C_Currency_IDUpdate stored procedure.


	public class CCurrencyIDUpdateCommand : IRequest<IList<CCurrencyId_CurrencyID>>
   {
		public string CurrencyID { get; set; }
		public string Name { get; set; }
		public long Enable { get; set; }
		public double? Current_Value_To_Birr { get; set; }
	}
		
		
		 
	}

