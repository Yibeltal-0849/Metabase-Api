using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblAddresses.proctblAddressesUpdate.proctblAddressesUpdateCommand
{

	/// @author  Shimels Alem  proc_tblAddressesUpdate stored procedure.


	public class proctblAddressesUpdateCommand : IRequest<IList<tblAddresses_id>>
   {
		public long id { get; set; }
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

