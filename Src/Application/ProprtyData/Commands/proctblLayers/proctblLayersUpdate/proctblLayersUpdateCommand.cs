using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblLayers.proctblLayersUpdate.proctblLayersUpdateCommand
{

	/// @author  Shimels Alem  proc_tblLayersUpdate stored procedure.


	public class proctblLayersUpdateCommand : IRequest<IList<tblLayers_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
		public string Back_Color { get; set; }
		public string Fill_Color { get; set; }
		public string Line_Color { get; set; }
		public string Outline_Color { get; set; }
		public bool EnableOutline { get; set; }
		public string Label_Column { get; set; }
		public string Label_ForeColor { get; set; }
		public string GIS_Column { get; set; }
		public string OID_Column { get; set; }
		public bool? Point { get; set; }
	}
		
		
		 
}

