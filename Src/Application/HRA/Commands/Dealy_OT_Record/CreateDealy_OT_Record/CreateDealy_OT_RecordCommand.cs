using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Dealy_OT_Record.CreateDealy_OT_Record
{
    /// @author  Shimels Alem  CreateCDealy_OT_Record stored procedure.
    
    public class CreateDealy_OT_RecordCommand : IRequest<IList<DealyOtRecord_Dealy_OT_Record_ID>>
    {
        public Guid? Dealy_OT_Record_ID { get; set; }
        public Guid? OR_ID { get; set; }
        public Guid? Deily_Attemdance_ID { get; set; }
        public Guid? OT_Type { get; set; }
        public double? Calculated_OT_Hours { get; set; }
        public double? Approved_OT_Hours { get; set; }
        public double? Calculated_Price { get; set; }
        public string Remark { get; set; }
    }
}
