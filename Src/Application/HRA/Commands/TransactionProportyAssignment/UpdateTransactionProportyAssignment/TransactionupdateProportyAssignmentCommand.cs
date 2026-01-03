using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.TransactionProportyAssignment.UpdateTransactionProportyAssignment
{
    /// @author  Shimels Alem  UpdateCEmployee stored procedure.
    
    public class TransactionupdateProportyAssignmentCommand : IRequest<IList<proc_Transaction_Proporty_AssignmentID>>
    {
        public System.Guid Trasn_Id { get; set; }
        public byte[] Documents { get; set; }
        public System.DateTime? Period { get; set; }
        public System.DateTime? Created_Date { get; set; }
    }
}
