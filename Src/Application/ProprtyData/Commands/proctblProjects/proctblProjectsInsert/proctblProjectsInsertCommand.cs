


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblProjects.proctblProjectsInsert.proctblProjectsInsertCommand
{

    /// @author  Shimels Alem  proc_tblRegionsInsert stored procedure.


    public class proctblProjectsInsertCommand : IRequest<IList<tblProjects_id>>
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
 
 