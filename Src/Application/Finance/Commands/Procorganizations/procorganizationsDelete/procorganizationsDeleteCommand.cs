using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procorganizationsDelete.procorganizationsDeleteCommand
{
    public class procorganizationsDeleteCommand : IRequest<IList<procorganizations_organization_Code>>
    {
        public Guid organization_Code { get; set; }
    }
}
