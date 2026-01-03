using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblWoredas.proctblWoredasUpdate.proctblWoredasUpdateCommand
{

	/// @author  Shimels Alem  proc_tblWoredasUpdate stored procedure.


	public class proctblWoredasUpdateCommand : IRequest<IList<tblWoredas_id>>
   {
		public long id { get; set; }
		public string description { get; set; }
		public int? zones_id { get; set; }
	}
		
		
		 
}

