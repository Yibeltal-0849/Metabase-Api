using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblSector.proctblSectorUpdate.proctblSectorUpdateCommand
{ 
	 
	/// @author  Shimels Alem  [sp not found] stored procedure.
	 
    
       public class proctblSectorUpdateCommand : IRequest<IList<tblSector_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
		public bool? Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Modified { get; set; }
	}
		
		
		 
}

