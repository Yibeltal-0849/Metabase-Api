

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;



namespace Application.Purchase.Commands.BidOpening.BidOpeningUpdate.BidOpeningUpdateCommand
{

    /// @author  Shimels Alem  proc_Bid_OpeningUpdate stored procedure.


    public class BidOpeningUpdateHandler : IRequestHandler<BidOpeningUpdateCommand, IList<BidOpening_ParticipantID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidOpeningUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BidOpening_ParticipantID>> Handle( BidOpeningUpdateCommand request, CancellationToken cancellationToken)
        {
            string Participant_ID = request.Participant_ID;
            System.DateTime? Techinical_Opening_Date = request.Techinical_Opening_Date;
            byte[] Techinical_Document_PDF_Format = request.Techinical_Document_PDF_Format;
            System.DateTime? Financial_Opening_Date = request.Financial_Opening_Date;
            byte[] Financial_Document_Password_Protected = request.Financial_Document_Password_Protected;
            string Remark = request.Remark;
            System.Guid? Updated_By = request.Updated_By;
            System.DateTime? Updated_Date = request.Updated_Date;
            System.DateTime? Last_Updated = request.Last_Updated;
            IList<BidOpening_ParticipantID> result = await _procedureAdabter
                .Execute<BidOpening_ParticipantID>("[Purchase].proc_Bid_OpeningUpdate",
                    (nameof(Participant_ID), Participant_ID),
                    (nameof(Techinical_Opening_Date), Techinical_Opening_Date),
                    (nameof(Techinical_Document_PDF_Format), Techinical_Document_PDF_Format),
                    (nameof(Financial_Opening_Date), Financial_Opening_Date),
                    (nameof(Financial_Document_Password_Protected), Financial_Document_Password_Protected),
                    (nameof(Remark), Remark),
                    (nameof(Updated_By), Updated_By),
                    (nameof(Updated_Date), Updated_Date),
                    (nameof(Last_Updated), Last_Updated)
                    );

            return result;
        }
    }
}
 