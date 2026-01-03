using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceProduct.proctblResourceProductUpdate.proctblResourceProductUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResource_ProductUpdate stored procedure.


	public class proctblResourceProductUpdateCommand : IRequest<IList<tblResourceProduct_id>>
   {
		public long id { get; set; }
		public long? Resource_Id { get; set; }
		public long? UseOrUsed_For { get; set; }
		public string Remark { get; set; }
	}
		
		
		 
}

