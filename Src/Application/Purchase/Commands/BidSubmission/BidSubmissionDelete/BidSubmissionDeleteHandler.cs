using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidSubmission.BidSubmissionDelete.BidSubmissionDeleteCommand
{

    /// @author  Shimels Alem  proc_Bid_SubmtionDelete stored procedure.


    public class BidSubmissionDeleteHandler : IRequestHandler<BidSubmissionDeleteCommand, IList<BidSubmission_ParticipantID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidSubmissionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BidSubmission_ParticipantID>> Handle( BidSubmissionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BidSubmission_ParticipantID> result = await _procedureAdabter
                .Execute<BidSubmission_ParticipantID>("[Purchase].proc_Bid_SubmtionDelete", request);
           

            return result;
        }
    }
}
  