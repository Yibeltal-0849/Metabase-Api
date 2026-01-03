using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Emplyee_Bio.DeleteByBioTypeAndEmpId
{
    /// @author  Shimels Alem  DeleteCEmplyee_Bio stored procedure.
    
    public class DeleteByBioTypeAndEmpIdCommand : IRequest<IList<EmplyeeBio_Emp_Bioid>>
    {
        public string Bio_Type { get; set; }
        public string Employee_ID { get; set; }
       
    }
}
