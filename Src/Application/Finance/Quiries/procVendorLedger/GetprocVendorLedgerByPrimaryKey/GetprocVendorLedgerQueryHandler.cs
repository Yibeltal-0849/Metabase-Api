using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procVendorLedger.GetprocVendorLedgerLoadAll;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Finance.Quiries.procVendorLedger.GetprocVendorLedgerByPrimaryKey
{
    public class GetprocVendorLedgerQueryHandler : IRequestHandler<GetprocVendorLedgerByPrimaryKey, GetprocVendorLedgerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocVendorLedgerQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVendorLedgerLoadAllListVm> Handle(GetprocVendorLedgerByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<VendorLedger> procVendorLedgers = await _procedureAdabter
               .Execute<VendorLedger>("[FINA].[proc_Vendor_LedgerLoadByPrimaryKey]", request);
            GetprocVendorLedgerLoadAllListVm vm = new GetprocVendorLedgerLoadAllListVm
            {
                procVendorLedgers = _mapper.Map<IList<VendorLedger>, IList<GetprocVendorLedgerLoadAllVm>>(procVendorLedgers)
            };

            return vm;
        }
    }
}
