


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblEnergyChain.proctblEnergyChainInsert.proctblEnergyChainInsertCommand
{

    /// @author  Shimels Alem  proc_tblEnergyChainInsert stored procedure.


    public class proctblEnergyChainInsertCommand : IRequest<IList<tblEnergyChain_id>>
    {
		public long? id { get; set; }
		public string Name { get; set; }
		public string Definition { get; set; }
		public bool? Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Last_Modified { get; set; }
	}
		
		
		 
}
 
 