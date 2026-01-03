using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblInstitution.proctblInstitutionUpdate.proctblInstitutionUpdateCommand
{

	/// @author  Shimels Alem  proc_tblInstitutionUpdate stored procedure.


	public class proctblInstitutionUpdateCommand : IRequest<IList<tblInstitution_id>>
   {
		public long id { get; set; }
		public long Address_id { get; set; }
		public string Name { get; set; }
		public long? Type { get; set; }
		public string Operating_Area { get; set; }
		public string Descripton_of_organization { get; set; }
		public string Registration_no { get; set; }
		public string Established_Year { get; set; }
		public string WebSite { get; set; }
		public string Country_of_origin { get; set; }
		public bool? Proclamation { get; set; }
		public string Capital { get; set; }
		public string Mistion { get; set; }
		public string Vistion { get; set; }
		public string Objective { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public byte[] Last_Modified { get; set; }
	}
		
		
		 
}

