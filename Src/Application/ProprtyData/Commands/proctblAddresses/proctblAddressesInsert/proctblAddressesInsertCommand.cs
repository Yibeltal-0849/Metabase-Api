


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblAddresses.proctblAddressesInsert.proctblAddressesInsertCommand
{

	/// @author  Shimels Alem  proc_tblAddressesInsert stored procedure.


	public class proctblAddressesInsertCommand : IRequest<IList<tblAddresses_id>>
    {
		public long? id { get; set; }
		public string Kebele { get; set; }
		public string Fax { get; set; }
		public string Pobox { get; set; }
		public string Email { get; set; }
		public bool? Local_forign { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public long? Woredas_id { get; set; }
	}
		
		
		 
}
 
 