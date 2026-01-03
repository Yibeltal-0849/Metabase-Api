using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CEmplye_Benefits.UpdateCEmplyeBenefits
{
    /// @author  Shimels Alem  UpdateCEmplyeBenefits stored procedure.
    
    public class UpdateCEmplyeBenefitsCommand : IRequest<IList<Proc_c_Emplye_Benefits_Name>>
    {
        public string Name { get; set; }
        public bool? Enable { get; set; }
    }
}
