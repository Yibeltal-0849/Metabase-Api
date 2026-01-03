using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblEnergyTypeChain.proctblEnergyTypeChainUpdate.proctblEnergyTypeChainUpdateCommand
{

	/// @author  Shimels Alem  proc_tblEnergy_Type_ChainUpdate stored procedure.


	public class proctblEnergyTypeChainUpdateCommand : IRequest<IList<tblEnergyTypeChain_id>>
   {
		public long id { get; set; }
		public long? Energy_Type_id { get; set; }
		public long? Energy_Chain_id { get; set; }
	}
		
		
		 
}

