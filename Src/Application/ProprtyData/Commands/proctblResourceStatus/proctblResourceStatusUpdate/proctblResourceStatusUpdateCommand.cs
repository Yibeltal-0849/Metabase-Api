using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceStatus.proctblResourceStatusUpdate.proctblResourceStatusUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResource_StatusUpdate stored procedure.


	public class proctblResourceStatusUpdateCommand : IRequest<IList<tblResourceStatus_id>>
	{
		public long id { get; set; }
		public string Status { get; set; }
		public bool? Enable { get; set; }

	}



}

