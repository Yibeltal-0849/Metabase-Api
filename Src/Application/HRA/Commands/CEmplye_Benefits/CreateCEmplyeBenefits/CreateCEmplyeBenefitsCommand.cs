using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CEmplye_Benefits.CreateCEmplyeBenefits
{
    /// @author  Shimels Alem  CreateCEmplyeBenefits stored procedure.
    
    public class CreateCEmplyeBenefitsCommand : IRequest<IList<Proc_c_Emplye_Benefits_Name>>
    {
        public string Name { get; set; }
        public bool? Enable { get; set; }
    }
}
