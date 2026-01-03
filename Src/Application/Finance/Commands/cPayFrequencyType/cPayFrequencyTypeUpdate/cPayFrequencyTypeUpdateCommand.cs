using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cPayFrequencyType.cPayFrequencyTypeUpdate.cPayFrequencyTypeUpdateCommand
{

	/// @author  Shimels Alem  c_PayFrequencyTypeUpdate stored procedure.


	public class cPayFrequencyTypeUpdateCommand : IRequest<IList<CPayFrequencyType_Name>>
   {
		public string Name { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
}

