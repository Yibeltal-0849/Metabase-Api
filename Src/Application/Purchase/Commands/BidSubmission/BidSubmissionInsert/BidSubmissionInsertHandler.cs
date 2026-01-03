



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;


namespace Application.Purchase.Commands.BidSubmission.BidSubmissionInsert.BidSubmissionInsertCommand
{

    /// @author  Shimels Alem  proc_Bid_SubmtionInsert stored procedure.


    public class BidSubmissionInsertHandler : IRequestHandler<BidSubmissionInsertCommand, IList<BidSubmission_ParticipantID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidSubmissionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BidSubmission_ParticipantID>> Handle( BidSubmissionInsertCommand request, CancellationToken cancellationToken)
        {
            string Participant_ID = request.Participant_ID;
            byte[] Techinical_Document_PDF_Format = request.Techinical_Document_PDF_Format;
            byte[] Financial_Document_Password_Protected = request.Financial_Document_Password_Protected;
            string Token_to_Financial_Document = request.Token_to_Financial_Document;
            System.Guid? Created_By = request.Created_By;
            System.Guid? Updated_By = request.Updated_By;
            System.DateTime? Created_Date = request.Created_Date;
            System.DateTime? Updated_Date = request.Updated_Date;
            System.DateTime? Last_Updated_Date = request.Last_Updated_Date;
            bool? Submited = request.Submited;
            System.Guid? Submited_By_User = request.Submited_By_User;
            System.DateTime? Submited_Date = request.Submited_Date;
            IList<BidSubmission_ParticipantID> result = await _procedureAdabter
                    .Execute<BidSubmission_ParticipantID>("[Purchase].proc_Bid_SubmtionInsert",
                    (nameof(Participant_ID), Participant_ID),
                    (nameof(Techinical_Document_PDF_Format), Techinical_Document_PDF_Format),
                    (nameof(Financial_Document_Password_Protected), Financial_Document_Password_Protected),
                    (nameof(Token_to_Financial_Document), Token_to_Financial_Document),
                    (nameof(Created_By), Created_By),
                    (nameof(Updated_By), Updated_By),
                    (nameof(Created_Date), Created_Date),
                    (nameof(Updated_Date), Updated_Date),
                    (nameof(Last_Updated_Date), Last_Updated_Date),
                    (nameof(Submited), Submited),
                    (nameof(Submited_By_User), Submited_By_User),
                    (nameof(Submited_Date), Submited_Date)
                    );
           

            return result;
        }
    }
}
 