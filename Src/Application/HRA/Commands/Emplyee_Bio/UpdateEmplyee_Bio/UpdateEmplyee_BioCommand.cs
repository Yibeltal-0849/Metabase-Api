using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Emplyee_Bio.UpdateEmplyee_Bio
{
    /// @author  Shimels Alem  UpdateCEmplyee_Bio stored procedure.
    
    public class UpdateEmplyee_BioCommand : IRequest<IList<EmplyeeBio_Emp_Bio>>
    {
        public Guid Emp_Bio { get; set; }
        public string Employee_ID { get; set; }
        public string Bio_Type { get; set; }
        public string Json_Bio_Data { get; set; }
        public string Json_Log { get; set; }
    }
}
