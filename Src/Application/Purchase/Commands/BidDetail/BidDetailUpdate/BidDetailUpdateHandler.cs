

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;



namespace Application.Purchase.Commands.BidDetail.BidDetailUpdate.BidDetailUpdateCommand
{

    /// @author  Shimels Alem  proc_Bid_DetailUpdate stored procedure.


    public class BidDetailUpdateHandler : IRequestHandler<BidDetailUpdateCommand, IList<Bid_Detail_Bid_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public BidDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Bid_Detail_Bid_DetailID>> Handle( BidDetailUpdateCommand request, CancellationToken cancellationToken)
        {
            System.Guid Bid_DetailID = request.Bid_DetailID;
            System.Guid? Bid_Detail_ID = request.Bid_Detail_ID;
            System.Guid? Budget_ID = request.Budget_ID;
            string PO_ID = request.PO_ID;
            int? Lot_No = request.Lot_No;
            string Name = request.Name;
            string Innitiative_ID = request.Innitiative_ID;
            string Budget_Detail_ID = request.Budget_Detail_ID;
            byte[] Document = request.Document;
            string Document_Description = request.Document_Description;
            string Bid_Section = request.Bid_Section;
            double? Lot_Price = request.Lot_Price;
            double? Bid_Security_ETB = request.Bid_Security_ETB;
            System.DateTime? Bid_Security_untill = request.Bid_Security_untill;
            string? bid_Description = request.bid_Description;
            IList<Bid_Detail_Bid_DetailID> result = await _procedureAdabter
                .Execute<Bid_Detail_Bid_DetailID>("[Purchase].proc_Bid_DetailUpdate",
                (nameof(Bid_DetailID), Bid_DetailID),
                (nameof(Bid_Detail_ID), Bid_Detail_ID),
                (nameof(Budget_ID), Budget_ID),
                (nameof(PO_ID), PO_ID),
                (nameof(Lot_No), Lot_No),
                (nameof(Name), Name),
                (nameof(Innitiative_ID), Innitiative_ID),
                (nameof(Budget_Detail_ID), Budget_Detail_ID),
                (nameof(Document), Document),
                (nameof(Document_Description), Document_Description),
                (nameof(Bid_Section), Bid_Section),
                (nameof(Lot_Price), Lot_Price),
                (nameof(Bid_Security_ETB), Bid_Security_ETB),
                (nameof(Bid_Security_untill), Bid_Security_untill),
                (nameof(bid_Description), bid_Description)
                );
           

            return result;
        }
    }
}
 