using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblElectricTransmissionDstribution.proctblElectricTransmissionDstributionUpdate.proctblElectricTransmissionDstributionUpdateCommand
{

	/// @author  Shimels Alem  proc_tblElectric_Transmission_DstributionUpdate stored procedure.


	public class proctblElectricTransmissionDstributionUpdateCommand : IRequest<IList<tblElectricTransmissionDstribution_id>>
   {
		public long id { get; set; }
		public long Region_id { get; set; }
		public System.DateTime Year { get; set; }
	}
		
		
		 
}

