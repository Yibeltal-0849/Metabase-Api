using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Employement_Request.DeleteEmployement_Request
{
    /// @author  Shimels Alem  DeleteCEmployement_Request stored procedure.
    
    public class DeleteEmployement_RequestCommand : IRequest<IList<EmployementRequest_JOBPost_ID>>
    {
        public Guid JOBPost_ID { get; set; }
    }
}
