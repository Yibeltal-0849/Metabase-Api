using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.EmployeeDoucment.UpdateEmployeeDoucment
{
    /// @author  Shimels Alem  UpdateCEmployee stored procedure.
    
    public class UpdateEmployeeDoucmentCommand : IRequest<IList<EmployeeDoucment_ID>>
    {
        public System.Guid ID { get; set; }
        public string Employee_Id { get; set; }
        public string Document_Name { get; set; }

        public byte[] Document_upload { get; set; }
        public string DocType { get; set; }
        public bool? IsDeleted { get; set; }
        public System.DateTime? Uploaded_Date
        {
            get; set;
        }
        public string? Penshion { get; set; }
    }
}
