using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumptionDetail.proctblConsumptionDetailUpdate.proctblConsumptionDetailUpdateCommand
{

	/// @author  Shimels Alem  proc_tblConsumption_DetailUpdate stored procedure.


	public class proctblConsumptionDetailUpdateCommand : IRequest<IList<tblConsumptionDetail_id>>
   {
		public long id { get; set; }
		public long Consumption_id { get; set; }
		public long SubSector_Id { get; set; }
		public long Unit_Id { get; set; }
		public string Sector_Number { get; set; }
		public decimal? Collected_Birr { get; set; }
		public decimal? Used_Amount { get; set; }
	}
		
		
		 
}

