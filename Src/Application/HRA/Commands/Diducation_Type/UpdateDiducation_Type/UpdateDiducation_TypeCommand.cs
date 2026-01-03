using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Diducation_Type.UpdateDiducation_Type
{
    /// @author  Shimels Alem  UpdateCDiducation_Type stored procedure.
    
    public class UpdateDiducation_TypeCommand : IRequest<IList<DiducationType_DiductionCode>>
    {
        public string DiductionCode { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public bool? IS_Forever { get; set; }
        public bool? Is_Before_Tax { get; set; }
        public string? GL_Account { get; set; }
        public bool? Is_Active { get; set; }
    }
}
