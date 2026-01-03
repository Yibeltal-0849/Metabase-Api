using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.EmployeeDoucment.DeleteEmployeeDoucment
{
    /// @author  Shimels Alem  DeleteCEmployee stored procedure.
    
    public class DeleteEmployeeDoucmentCommand : IRequest<IList<EmployeeDoucment_ID>>
    {
        public Guid ID { get; set; }
    }
}
