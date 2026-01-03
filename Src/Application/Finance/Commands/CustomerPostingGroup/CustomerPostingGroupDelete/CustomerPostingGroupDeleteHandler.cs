using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CustomerPostingGroup.CustomerPostingGroupDelete.CustomerPostingGroupDeleteCommand
{

    /// @author  Shimels Alem  Customer_Posting_GroupDelete stored procedure.


    public class CustomerPostingGroupDeleteHandler : IRequestHandler<CustomerPostingGroupDeleteCommand, IList<CustomerPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CustomerPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CustomerPostingGroup_Code>> Handle( CustomerPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CustomerPostingGroup_Code> result = await _procedureAdabter
                .Execute<CustomerPostingGroup_Code>("[FINA].Customer_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
  