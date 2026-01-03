using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;


namespace Application.dbo.Commands.procAdjudicated.procAdjudicatedDelete
{
    public class procAdjudicatedDeleteCommand : IRequest<IList<AdjudicatedCode>>
    {

        public System.Guid Adjudicated_Code { get; set; }
    }
}
