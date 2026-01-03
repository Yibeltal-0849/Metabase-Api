

using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.procReciveRent.procContractReciveRentDelete.procReciveRentDeleteCommand
{
    public class procReciveRentDeleteCommand : IRequest<IList<ReciveRentRent_Collection_ID>>
    {
        public System.Guid Rent_Collection_ID { get; set; }
    }
}
