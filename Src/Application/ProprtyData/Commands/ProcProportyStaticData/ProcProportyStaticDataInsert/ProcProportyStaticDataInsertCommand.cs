


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.ProcProportyStaticData.ProcProportyStaticDataInsert.ProcProportyStaticDataInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class ProcProportyStaticDataInsertCommand : IRequest<IList<Proporty_Static_DataID>>
    {
       
            public System.Guid ID { get; set; }
            public string Property_ID { get; set; }
            public string Static_form_Data { get; set; }
            public Nullable<System.DateTime> Collection_Date { get; set; }
            public Nullable<bool> Is_Active { get; set; }
        
    }
		
		
		 
}
 
 