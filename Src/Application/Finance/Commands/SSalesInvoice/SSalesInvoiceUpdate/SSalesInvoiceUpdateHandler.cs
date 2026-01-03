

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.SSalesInvoice.SSalesInvoiceUpdate.SSalesInvoiceUpdateCommand
{

    /// @author  Shimels Alem  S_Sales_InvoiceUpdate stored procedure.


    public class SSalesInvoiceUpdateHandler : IRequestHandler<SSalesInvoiceUpdateCommand, IList<SSalesInvoice_Sales_Invoice_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalesInvoiceUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesInvoice_Sales_Invoice_Line>> Handle( SSalesInvoiceUpdateCommand request, CancellationToken cancellationToken)
        {

           IList <SSalesInvoice_Sales_Invoice_Line> result = await _procedureAdabter
                .Execute<SSalesInvoice_Sales_Invoice_Line>("[FINA].S_Sales_InvoiceUpdate", request);
           
            return result;
        }
    }
}
 