


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumption.proctblConsumptionInsert.proctblConsumptionInsertCommand
{

    /// @author  Shimels Alem  proc_tblConsumptionInsert stored procedure.


    public class proctblConsumptionInsertCommand : IRequest<IList<tblConsumption_id>>
    {
        public long? id { get; set; }
        public string Tranaction_Id { get; set; }
        public long? Companys_id { get; set; }
        public long? Energy_Id { get; set; }
        public bool? Complited { get; set; }
    }
		
		
		 
}
 
 