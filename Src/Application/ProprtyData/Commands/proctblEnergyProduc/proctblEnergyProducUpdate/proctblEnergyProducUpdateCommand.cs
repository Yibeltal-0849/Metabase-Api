using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblEnergyProduc.proctblEnergyProducUpdate.proctblEnergyProducUpdateCommand
{

	/// @author  Shimels Alem  proc_tblEnergyProducUpdate stored procedure.


	public class proctblEnergyProducUpdateCommand : IRequest<IList<tblEnergyProduc_Id>>
   {
		public long Id { get; set; }
		public string Energy_Number { get; set; }
		public string Name { get; set; }
		public string Remark { get; set; }
	}
		
		
		 
}

