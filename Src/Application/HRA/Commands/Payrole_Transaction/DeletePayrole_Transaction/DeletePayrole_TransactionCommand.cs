using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Payrole_Transaction.DeletePayrole_Transaction
{
    /// @author  Shimels Alem  proc_Payrole_TransactionDelete stored procedure.

    public class DeletePayrole_TransactionCommand : IRequest<IList<PayroleTransaction_Payrole_Trans_Id>>
    {
        public Guid Payrole_Trans_Id { get; set; }
    }
}
