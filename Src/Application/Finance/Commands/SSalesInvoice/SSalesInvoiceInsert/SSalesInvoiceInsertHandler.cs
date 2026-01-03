



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.SSalesInvoice.SSalesInvoiceInsert.SSalesInvoiceInsertCommand
{

    /// @author  Shimels Alem  S_Sales_InvoiceInsert stored procedure.


    public class SSalesInvoiceInsertHandler : IRequestHandler<SSalesInvoiceInsertCommand, IList<SSalesInvoice_Sales_Invoice_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalesInvoiceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesInvoice_Sales_Invoice_Line>> Handle( SSalesInvoiceInsertCommand request, CancellationToken cancellationToken)
        {

            IList<SSalesInvoice_Sales_Invoice_Line> result = await _procedureAdabter
                .Execute<SSalesInvoice_Sales_Invoice_Line>("[FINA].S_Sales_InvoiceInsert", request);
           

            return result;
        }
    }
}
 