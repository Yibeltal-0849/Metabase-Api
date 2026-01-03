



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.PPurchaseInvoice.PPurchaseInvoiceInsert.PPurchaseInvoiceInsertCommand
{

    /// @author  Shimels Alem  [P_Purchase_InvoiceInsert] stored procedure.


    public class PPurchaseInvoiceInsertHandler : IRequestHandler<PPurchaseInvoiceInsertCommand, IList<P_Purchase_Invoice_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchaseInvoiceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<P_Purchase_Invoice_Purchase_Line>> Handle( PPurchaseInvoiceInsertCommand request, CancellationToken cancellationToken)
        {

            IList<P_Purchase_Invoice_Purchase_Line> result = await _procedureAdabter
                .Execute<P_Purchase_Invoice_Purchase_Line>("[FINA].[P_Purchase_InvoiceInsert]", request);
           

            return result;
        }
    }
}
 