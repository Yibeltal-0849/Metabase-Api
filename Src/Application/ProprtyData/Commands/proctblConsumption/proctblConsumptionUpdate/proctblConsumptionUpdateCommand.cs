using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumption.proctblConsumptionUpdate.proctblConsumptionUpdateCommand
{

	/// @author  Shimels Alem  proc_tblConsumptionUpdate stored procedure.


	public class proctblConsumptionUpdateCommand : IRequest<IList<tblConsumption_id>>
   {
		public long id { get; set; }
		public string Tranaction_Id { get; set; }
		public long? Companys_id { get; set; }
		public long? Energy_Id { get; set; }
		public bool? Complited { get; set; }
	}
		
		
		 
}

