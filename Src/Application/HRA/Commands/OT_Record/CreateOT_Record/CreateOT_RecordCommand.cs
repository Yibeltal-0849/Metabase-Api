using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.OT_Record.CreateOT_Record
{
    /// @author  Shimels Alem  CreateCOT_Record stored procedure.
    
    public class CreateOT_RecordCommand : IRequest<IList<OtRecord_OT_ID>>
    {
        public Guid? OT_ID { get; set; }
        public Guid? Att_OT_Trans_Id { get; set; }
        public DateTime? Start_Date_Time { get; set; }
        public DateTime? End_Date_Time { get; set; }
        public string Reason { get; set; }
        public string Managment_Reason { get; set; }
    }
}
