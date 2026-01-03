using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblElectricTransDstrDetail.proctblElectricTransDstrDetailUpdate.proctblElectricTransDstrDetailUpdateCommand
{

	/// @author  Shimels Alem  proc_tblElectric_Trans_Dstr_DetailUpdate stored procedure.


	public class proctblElectricTransDstrDetailUpdateCommand : IRequest<IList<tblElectricTransDstrDetail_id>>
   {
		public long id { get; set; }
		public long? ETD_ID { get; set; }
		public string Number_of_Substation_by_voltage_level { get; set; }
		public string Transmissions_line_length_in_km_by_voltage_level { get; set; }
		public string Distribution_line_length_by_voltage_level { get; set; }
		public string No_of_distribution_transformers { get; set; }
	}
		
		
		 
}

