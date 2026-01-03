using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procSSalesInvoice.GetprocSSalesInvoiceLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procSSalesInvoice.GetprocSSalesInvoiceByPrimaryKey
{
    public class GetprocSSalesInvoiceQueryHandler : IRequestHandler<GetprocSSalesInvoiceByPrimaryKey, GetprocSSalesInvoiceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSSalesInvoiceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSSalesInvoiceLoadAllListVm> Handle(GetprocSSalesInvoiceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SSalesInvoice> procSSalesInvoices = await _procedureAdabter
               .Execute<SSalesInvoice>("[FINA].[proc_S_Sales_InvoiceLoadByPrimaryKey]", request);
            GetprocSSalesInvoiceLoadAllListVm vm = new GetprocSSalesInvoiceLoadAllListVm
            {
                procSSalesInvoices = _mapper.Map<IList<SSalesInvoice>, IList<GetprocSSalesInvoiceLoadAllVm>>(procSSalesInvoices)
            };

            return vm;
        }
    }
}
