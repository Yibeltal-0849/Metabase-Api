using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblProjects.proctblProjectsUpdate.proctblProjectsUpdateCommand
{

	/// @author  Shimels Alem  proc_tblProjectsUpdate stored procedure.


	public class proctblProjectsUpdateCommand : IRequest<IList<tblProjects_id>>
   {
		public long? id { get; set; }
		public long? Companys_Id { get; set; }
		public long? Status { get; set; }
		public string name { get; set; }
		public string Areas { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public string Objective { get; set; }
		public string Description { get; set; }
		public string Results { get; set; }
	}
		
		
		 
	}

