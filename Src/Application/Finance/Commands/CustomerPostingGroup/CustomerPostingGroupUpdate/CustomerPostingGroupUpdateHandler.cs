

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.CustomerPostingGroup.CustomerPostingGroupUpdate.CustomerPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  Customer_Posting_GroupUpdate stored procedure.


    public class CustomerPostingGroupUpdateHandler : IRequestHandler<CustomerPostingGroupUpdateCommand, IList<CustomerPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CustomerPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CustomerPostingGroup_Code>> Handle( CustomerPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CustomerPostingGroup_Code> result = await _procedureAdabter
                .Execute<CustomerPostingGroup_Code>("[FINA].Customer_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 