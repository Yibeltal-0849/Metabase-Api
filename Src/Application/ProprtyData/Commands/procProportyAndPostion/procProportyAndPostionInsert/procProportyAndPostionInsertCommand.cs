


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procProportyAndPostion.procProportyAndPostionInsert.procProportyAndPostionInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class procProportyAndPostionInsertCommand : IRequest<IList<Proporty_And_PostionID>>
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> Position_ID { get; set; }
        public string Property_ID { get; set; }
        public Nullable<int> Priority { get; set; }
        public bool IsActive { get; set; }
    }
		
		
		 
}
 
 