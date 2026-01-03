using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Diducation_Type.DeleteDiducation_Type
{
    /// @author  Shimels Alem  DeleteCDiducation_Type stored procedure.
    
    public class DeleteDiducation_TypeCommand : IRequest<IList<DiducationType_DiductionCode>>
    {
        public string DiductionCode { get; set; }
    }
}
