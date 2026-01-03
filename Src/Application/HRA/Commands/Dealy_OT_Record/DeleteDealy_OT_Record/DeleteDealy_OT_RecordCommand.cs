using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Dealy_OT_Record.DeleteDealy_OT_Record
{
    /// @author  Shimels Alem  DeleteCDealy_OT_Record stored procedure.
    
    public class DeleteDealy_OT_RecordCommand : IRequest<IList<DealyOtRecord_Dealy_OT_Record_ID>>
    {
        public Guid Dealy_OT_Record_ID { get; set; }
    }
}
