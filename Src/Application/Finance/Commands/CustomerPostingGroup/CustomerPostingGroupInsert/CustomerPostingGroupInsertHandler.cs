



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CustomerPostingGroup.CustomerPostingGroupInsert.CustomerPostingGroupInsertCommand
{

    /// @author  Shimels Alem  Customer_Posting_GroupInsert stored procedure.


    public class CustomerPostingGroupInsertHandler : IRequestHandler<CustomerPostingGroupInsertCommand, IList<CustomerPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CustomerPostingGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CustomerPostingGroup_Code>> Handle( CustomerPostingGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CustomerPostingGroup_Code> result = await _procedureAdabter
                .Execute<CustomerPostingGroup_Code>("[FINA].Customer_Posting_GroupInsert", request);
           

            return result;
        }
    }
}
 