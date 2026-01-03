using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceGISLayer.proctblResourceGISLayerUpdate.proctblResourceGISLayerUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResource_GISLayerUpdate stored procedure.


	public class proctblResourceGISLayerUpdateCommand : IRequest<IList<tblResourceGISLayer_Resource_id>>
   {
		public long Resource_id { get; set; }
		public long FID { get; set; }
		public long? LayerId { get; set; }
		public long? Chain { get; set; }
		public long? Energy { get; set; }
	}
		
		
		 
}

