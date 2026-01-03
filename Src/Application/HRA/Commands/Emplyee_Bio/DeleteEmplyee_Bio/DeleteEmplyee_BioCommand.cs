using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Emplyee_Bio.DeleteEmplyee_Bio
{
    /// @author  Shimels Alem  DeleteCEmplyee_Bio stored procedure.
    
    public class DeleteEmplyee_BioCommand : IRequest<IList<EmplyeeBio_Emp_Bio>>
    {
        public Guid Emp_Bio { get; set; }
    }
}
