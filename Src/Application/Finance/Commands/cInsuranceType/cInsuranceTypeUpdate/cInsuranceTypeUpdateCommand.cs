using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cInsuranceType.cInsuranceTypeUpdate.cInsuranceTypeUpdateCommand
{

	/// @author  Shimels Alem  c_InsuranceTypeUpdate stored procedure.


	public class cInsuranceTypeUpdateCommand : IRequest<IList<CInsuranceType_Name>>
   {
		public string Name { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
	}

