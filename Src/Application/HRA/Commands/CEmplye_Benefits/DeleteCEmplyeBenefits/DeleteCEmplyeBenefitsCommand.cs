using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CEmplye_Benefits.DeleteCEmplyeBenefits
{
    /// @author  Shimels Alem  DeleteCEmplyeBenefits stored procedure.
    
    public class DeleteCEmplyeBenefitsCommand : IRequest<IList<Proc_c_Emplye_Benefits_Name>>
    {
        public string Name { get; set; }
    }
}
