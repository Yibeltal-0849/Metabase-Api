using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.TransactionProportyAssignment.DeleteTransactionProportyAssignment
{
    /// @author  Shimels Alem  DeleteCEmployee stored procedure.
    
    public class DeleteTransactionProportyAssignmentCommand : IRequest<IList<proc_Transaction_Proporty_AssignmentID>>
    {
        public System.Guid Trasn_Id { get; set; }
    }
}
