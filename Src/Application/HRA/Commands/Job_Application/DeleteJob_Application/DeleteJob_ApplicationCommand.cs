using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Job_Application.DeleteJob_Application
{
    /// @author  Shimels Alem  DeleteCJob_Application stored procedure.
    
    public class DeleteJob_ApplicationCommand : IRequest<IList<JobApplication_Job_AppID>>
    {
        public string Job_AppID { get; set; }
    }
}
