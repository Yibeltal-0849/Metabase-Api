


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Vehicle.Commands.procFleetSchdule.procFleetSchduleInsert.procFleetSchduleInsertCommand
{

    /// @author  Shimels Alem  proc_Fleet_SchduleInsert stored procedure.


    public class procFleetSchduleInsertCommand : IRequest<IList<FleetSchdule_Fleet_SchduleID>>
    {
        public System.Guid Fleet_SchduleID { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public System.Guid? Vehicle_ID { get; set; }
        public System.Guid? Fleet_ContractID { get; set; }
        public string Vendor_ID { get; set; }
        public string Title { get; set; }
        public System.DateTime? Registration_Date { get; set; }
        public System.Guid? Fleet_Schdule_Type { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}
 
 