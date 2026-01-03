 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceProduction.proctblResourceProductionDelete.proctblResourceProductionDeleteCommand
{

    // @author  Shimels Alem  proc_tblResourceProductionDelete stored procedure.


    public class proctblResourceProductionDeleteCommand : IRequest<IList<tblResourceProduction_Facility_id>>
    {
        public long Facility_id { get; set; }
        public long Variable_id { get; set; }
        public System.DateTime Production_Period { get; set; }
    }
		
     
		
		 
}
 
 