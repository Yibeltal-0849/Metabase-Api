


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procProportyAssignment.procProportyAssignmentInsert.procProportyAssignmentInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class procProportyAssignmentInsertCommand : IRequest<IList<Proporty_AssignmentID>>
    {
        public System.Guid Assig_Id { get; set; }
        public Nullable<System.Guid> Trans_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Proporty_ID { get; set; }
        public Nullable<System.Guid> Rent_App_ID { get; set; }
        public Nullable<System.Guid> Manual_Rent_App_ID { get; set; }
        public string Remark_for_Manual_Assigment { get; set; }
        public Nullable<bool> Approved { get; set; }
        public System.Guid UserID { get; set; }
    }
		
		
		 
}
 
 