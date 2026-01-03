using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.IssueDetail.IssueDetailDelete.IssueDetailDeleteCommand
{

    /// @author  Shimels Alem  Issue_DetailDelete stored procedure.


    public class IssueDetailDeleteHandler : IRequestHandler<IssueDetailDeleteCommand, IList<IssueDetail_IssueDetail_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public IssueDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<IssueDetail_IssueDetail_ID>> Handle( IssueDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<IssueDetail_IssueDetail_ID> result = await _procedureAdabter
                .Execute<IssueDetail_IssueDetail_ID>("[Inventory].Issue_DetailDelete", request);
           

            return result;
        }
    }
}
  