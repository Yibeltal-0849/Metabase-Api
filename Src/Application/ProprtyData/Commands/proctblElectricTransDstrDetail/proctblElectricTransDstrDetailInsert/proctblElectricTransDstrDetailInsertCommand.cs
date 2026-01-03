


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblElectricTransDstrDetail.proctblElectricTransDstrDetailInsert.proctblElectricTransDstrDetailInsertCommand
{

    /// @author  Shimels Alem  proc_tblElectric_Trans_Dstr_DetailInsert stored procedure.


    public class proctblElectricTransDstrDetailInsertCommand : IRequest<IList<tblElectricTransDstrDetail_id>>
    {
		public long? id { get; set; }
		public long? ETD_ID { get; set; }
		public string Number_of_Substation_by_voltage_level { get; set; }
		public string Transmissions_line_length_in_km_by_voltage_level { get; set; }
		public string Distribution_line_length_by_voltage_level { get; set; }
		public string No_of_distribution_transformers { get; set; }
	}
		
		
		 
}
 
 