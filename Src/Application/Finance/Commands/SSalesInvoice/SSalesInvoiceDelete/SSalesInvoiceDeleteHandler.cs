using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SSalesInvoice.SSalesInvoiceDelete.SSalesInvoiceDeleteCommand
{

    /// @author  Shimels Alem  S_Sales_InvoiceDelete stored procedure.


    public class SSalesInvoiceDeleteHandler : IRequestHandler<SSalesInvoiceDeleteCommand, IList<SSalesInvoice_Sales_Invoice_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalesInvoiceDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesInvoice_Sales_Invoice_Line>> Handle( SSalesInvoiceDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<SSalesInvoice_Sales_Invoice_Line> result = await _procedureAdabter
                .Execute<SSalesInvoice_Sales_Invoice_Line>("[FINA].S_Sales_InvoiceDelete", request);
           

            return result;
        }
    }
}
  