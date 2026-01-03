using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cEmplyeBenefits.cEmplyeBenefitsUpdate.cEmplyeBenefitsUpdateCommand
{

	/// @author  Shimels Alem  c_Emplye_BenefitsUpdate stored procedure.


	public class cEmplyeBenefitsUpdateCommand : IRequest<IList<CEmplyeBenefits_Name>>
   {
		public string Name { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
	}

