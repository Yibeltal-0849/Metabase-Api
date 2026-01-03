using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procPPurchaseInvoice.GetprocPPurchaseInvoiceLoadAll
{
    class GetprocPPurchaseInvoiceLoadAllQueryHandler : IRequestHandler<GetprocPPurchaseInvoiceLoadAllQuery, GetprocPPurchaseInvoiceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPPurchaseInvoiceLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPPurchaseInvoiceLoadAllListVm> Handle(GetprocPPurchaseInvoiceLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<P_Purchase_Invoice> procPPurchaseInvoices = await _procedureAdabter
               .Execute<P_Purchase_Invoice>("[FINA].[proc_P_Purchase_InvoiceLoadAll]");
            GetprocPPurchaseInvoiceLoadAllListVm vm = new GetprocPPurchaseInvoiceLoadAllListVm
            {
                procPPurchaseInvoices = _mapper.Map<IList<P_Purchase_Invoice>, IList<GetprocPPurchaseInvoiceLoadAllVm>>(procPPurchaseInvoices)
            };

            return vm;
        }
    }
}
