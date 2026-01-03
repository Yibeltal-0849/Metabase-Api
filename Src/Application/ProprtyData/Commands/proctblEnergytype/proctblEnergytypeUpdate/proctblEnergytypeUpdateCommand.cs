using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblEnergytype.proctblEnergytypeUpdate.proctblEnergytypeUpdateCommand
{

	/// @author  Shimels Alem  proc_tblEnergy_typeUpdate stored procedure.


	public class proctblEnergytypeUpdateCommand : IRequest<IList<tblEnergytype_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
	}
		
		
		 
}

