using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblOrganizationType.proctblOrganizationTypeUpdate.proctblOrganizationTypeUpdateCommand
{

	/// @author  Shimels Alem  proc_tblOrganization_TypeUpdate stored procedure.


	public class proctblOrganizationTypeUpdateCommand : IRequest<IList<tblOrganizationType_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
	}
		
		
		 
}

