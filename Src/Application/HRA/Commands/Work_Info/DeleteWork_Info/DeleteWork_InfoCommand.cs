using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Work_Info.DeleteWork_Info
{
    /// @author  Shimels Alem  DeleteCWork_Info stored procedure.
    
    public class DeleteWork_InfoCommand : IRequest<IList<WorkInfo_WorkInfo_ID>>
    {
        public Guid WorkInfo_ID { get; set; }
    }
}
