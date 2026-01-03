

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.IssueDetail.IssueDetailUpdate.IssueDetailUpdateCommand
{

    /// @author  Shimels Alem  Issue_DetailUpdate stored procedure.


    public class IssueDetailUpdateHandler : IRequestHandler<IssueDetailUpdateCommand, IList<IssueDetail_IssueDetail_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public IssueDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<IssueDetail_IssueDetail_ID>> Handle( IssueDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<IssueDetail_IssueDetail_ID> result = await _procedureAdabter
                .Execute<IssueDetail_IssueDetail_ID>("[Inventory].Issue_DetailUpdate", request);
           

            return result;
        }
    }
}
 