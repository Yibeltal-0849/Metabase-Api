using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procVendorLedger.GetprocVendorLedgerLoadAll
{
    class GetprocVendorLedgerLoadAllQueryHandler : IRequestHandler<GetprocVendorLedgerLoadAllQuery, GetprocVendorLedgerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVendorLedgerLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVendorLedgerLoadAllListVm> Handle(GetprocVendorLedgerLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VendorLedger> procVendorLedgers = await _procedureAdabter
               .Execute<VendorLedger>("[FINA].[proc_Vendor_LedgerLoadAll]");
            GetprocVendorLedgerLoadAllListVm vm = new GetprocVendorLedgerLoadAllListVm
            {
                procVendorLedgers = _mapper.Map<IList<VendorLedger>, IList<GetprocVendorLedgerLoadAllVm>>(procVendorLedgers)
            };

            return vm;
        }
    }
}
