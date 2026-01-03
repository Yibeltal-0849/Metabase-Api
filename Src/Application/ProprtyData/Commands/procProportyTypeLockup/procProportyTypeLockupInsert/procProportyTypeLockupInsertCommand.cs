


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procProportyTypeLockup.procProportyTypeLockupInsert.procProportyTypeLockupInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class procProportyTypeLockupInsertCommand : IRequest<IList<Proporty_Type_LookUpID>>
    {
        public int Property_Type_ID { get; set; }
        public string Property_Type { get; set; }
            public int Interval_Month { get; set; }
            public string Static_Json_from { get; set; }
            public string Dinamic_Json_form { get; set; }
            public Nullable<bool> Is_Deleted { get; set; }
        
    }
		
		
		 
}
 
 