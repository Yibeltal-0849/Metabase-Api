using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblSubSectors.proctblSubSectorsUpdate.proctblSubSectorsUpdateCommand
{

	/// @author  Shimels Alem  proc_tblSubSectorsUpdate stored procedure.


	public class proctblSubSectorsUpdateCommand : IRequest<IList<tblSubSectors_id>>
   {
		public long id { get; set; }
		public long? Main_Sector_id { get; set; }
		public string Name { get; set; }
		public string Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
	}
		
		
		 
}

