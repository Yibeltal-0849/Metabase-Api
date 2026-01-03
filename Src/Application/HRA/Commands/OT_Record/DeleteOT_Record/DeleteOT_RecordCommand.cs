using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.OT_Record.DeleteOT_Record
{
    /// @author  Shimels Alem  DeleteCOT_Record stored procedure.
    
    public class DeleteOT_RecordCommand : IRequest<IList<OtRecord_OT_ID>>
    {
        public Guid OT_ID { get; set; }
    }
}
