using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblFacilityGISLayer.proctblFacilityGISLayerUpdate.proctblFacilityGISLayerUpdateCommand
{ 
	 
	/// @author  Shimels Alem  [no sp found] stored procedure.
	 
    
       public class proctblFacilityGISLayerUpdateCommand : IRequest<IList<tblFacilityGISLayer_Facility_id>>
   {
		public long Facility_id { get; set; }
		public long FID { get; set; }
	}
		
		
		 
}

