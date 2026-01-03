using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblImport.proctblImportUpdate.proctblImportUpdateCommand
{

	/// @author  Shimels Alem  proc_tblImportUpdate stored procedure.


	public class proctblImportUpdateCommand : IRequest<IList<tblImport_id>>
   {
		public long id { get; set; }
		public long Company_id { get; set; }
		public long? Energy_Chain_id { get; set; }
		public long? Energy_id { get; set; }
		public long Supplier_id { get; set; }
		public System.DateTime Imported_Period { get; set; }
		public decimal Value { get; set; }
		public long Unit { get; set; }
	}
		
		
		 
}

