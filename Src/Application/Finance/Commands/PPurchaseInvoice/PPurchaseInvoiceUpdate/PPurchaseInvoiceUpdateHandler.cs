

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.PPurchaseInvoice.PPurchaseInvoiceUpdate.PPurchaseInvoiceUpdateCommand
{

    /// @author  Shimels Alem  [P_Purchase_InvoiceUpdate] stored procedure.


    public class PPurchaseInvoiceUpdateHandler : IRequestHandler<PPurchaseInvoiceUpdateCommand, IList<P_Purchase_Invoice_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchaseInvoiceUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<P_Purchase_Invoice_Purchase_Line>> Handle( PPurchaseInvoiceUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<P_Purchase_Invoice_Purchase_Line> result = await _procedureAdabter
                .Execute<P_Purchase_Invoice_Purchase_Line>("[FINA].[P_Purchase_InvoiceUpdate]", request);
           

            return result;
        }
    }
}
 