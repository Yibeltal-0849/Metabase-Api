using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceSuppliers.proctblResourceSuppliersUpdate.proctblResourceSuppliersUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResourceSuppliersUpdate stored procedure.


	public class proctblResourceSuppliersUpdateCommand : IRequest<IList<tblResourceSuppliers_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public string Ownership { get; set; }
	}
		
		
		 
}

