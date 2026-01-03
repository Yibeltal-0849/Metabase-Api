



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.IssueDetail.IssueDetailInsert.IssueDetailInsertCommand
{

    /// @author  Shimels Alem  Issue_DetailInsert stored procedure.


    public class IssueDetailInsertHandler : IRequestHandler<IssueDetailInsertCommand, IList<IssueDetail_IssueDetail_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public IssueDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<IssueDetail_IssueDetail_ID>> Handle( IssueDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<IssueDetail_IssueDetail_ID> result = await _procedureAdabter
                .Execute<IssueDetail_IssueDetail_ID>("[Inventory].Issue_DetailInsert", request);
           

            return result;
        }
    }
}
 